using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextToSign : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public InputField inf;
    public Text dt;
    public Text newtext;
    public bool c = false;
    //public TextMeshProUGUI dt;
    void Start()
    {
        Color newColor = new Color(0.3f, 0.4f, 0.6f);
    }

    #region Hamza Anim Code

    public string[] words;
    int currentTextLength = 0;

    public void SplitText()// calling on ok button (called only once after button pressed)
    {
        dt.color = Color.black;
        dt.text = inf.text.ToString();
        currentTextLength = 0;
        words = inf.text.ToString().Split(' ');//split text through space
        InvokeRepeating("PlayAnim", 1f, 1.8f);
      
    }
    public void PlayAnim()
    {  
     
        anim.CrossFadeInFixedTime(words[currentTextLength], 0.1f);
        dt.color = Color.yellow;
        currentTextLength++;
        if (currentTextLength == words.Length)
        {
           
            CancelInvoke("PlayAnim");
            inf.text = "";


        }
    }
    #endregion
    //public IEnumerator highlight()
  
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReceiveResult : MonoBehaviour {

    // Use this for initialization
    public Animator anim;
    public InputField inf;
    public TextToSign tts;
    void Start () {
        //GameObject.Find("Text").GetComponent<Text>().text = "You need to be connected to Internet";
	}
	
    void onActivityResult(string recognizedText){
        char[] delimiterChars = {'~'};
        string[] result = recognizedText.Split(delimiterChars);
         
            //GameObject.Find("Text").GetComponent<Text>().text = "Allah ka shuker app sunaay";
            GameObject.Find("Text").GetComponent<Text>().text = result[0];
            //tts.words[] = "Hello how are you";

            inf.text = result[0].ToString();
            tts.SplitText();
            





       

        //You can get the number of results with result.Length
        //And access a particular result with result[i] where i is an int
        //I have just assigned the best result to UI text
       // GameObject.Find("Text").GetComponent<Text>().text = result[0];

    }

	// Update is called once per frame
	void Update () {
		
	}
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userinput : MonoBehaviour {

    // Use this for initialization
    //void Start () {	}
    // Update is called once per frame
    //void Update () {}

    //public InputField UserString;
    //public Text output;

    //public void input()
    //{
    //    output.text = "input value is " + UserString.text + " end text";
    //}

    public InputField UserString;
    public Text output;

    //public float speed;
    //public float notspeed;
    public Animator anim;
    public GameObject gameobject;
    // Use this for initialization
    void Start () {
        anim = gameobject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetTrigger("Ishow");
             anim.SetBool("IsHello", true);
            //anim.SetBool("IsIdel", false);
            
        }
        else
        {
            anim.SetTrigger("Isidel");
        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("IsHello", true);
            anim.SetBool("IsIdel", false);
        }
        else
        {
            anim.SetBool("IsHello", false);
            anim.SetBool("IsIdel", true);
        }

    }

    public void Play()
    {
        string str = UserString.text;
        char[] seperator = { ' ' };
        string[] words = str.Split(seperator);
        output.text = words[0];
        //words[0] == "Hello"
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("IsHello", true);
        }
        else
        {
            anim.SetTrigger("Ishow");
        }


    }

    public void input(){
        string str = UserString.text;
        char[] seperator = { ' ' };
        string[] words = str.Split(seperator);
        output.text = words[0];
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("IsHello", true);
        }
        else
        {
            anim.SetTrigger("Ishow");
        }






        //sab yaha tak

        //for (int i = 0; i < words.Length; i++)
        //{
        // output.text = words[];
        //}
    }


}

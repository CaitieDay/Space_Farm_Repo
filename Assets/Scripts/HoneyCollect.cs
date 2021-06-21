using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoneyCollect : MonoBehaviour
{
    //VARS
    private bool touchingJar = false;
    public GameObject FullJar;
    public Text Text;

    // Update is called once per frame
    void Update()
    {
        // if e is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            //check for players collison with the game object tagged Jars
            if (touchingJar)
            {

            }
        }

    }

    void OnTriggerEnter (Collider Jars)
    {
        if (Jars.tag == "FullJar")
        {
            touchingJar = true; 
        }
    }

    void OnTriggerExit (Collider Jars)
    {
        if (Jars.tag == "FullJar")
        {
            touchingJar = false;
        }
    }
   
}

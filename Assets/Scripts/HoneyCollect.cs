using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyCollect : MonoBehaviour
{
    //VARS
    private bool touchingJar = false;


    // Update is called once per frame
    void Update()
    {
        // if e is pressed
        if ((Input.GetKeyDown(KeyCode.E)) && (OnTriggerEnter))
        {

        }

        void OnTriggerEnter (Collider FullJar)
        {
            if (FullJar.tag == Jars)
            {
                touchingJar = true; 
            }
        }

        void OnTriggerExit (Collider FullJar)
        {
            if (FullJar.tag == Jars)
            {
                touchingJar = false;
            }
        }
    }
}

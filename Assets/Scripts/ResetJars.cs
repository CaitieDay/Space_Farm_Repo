using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetJars : MonoBehaviour
{
    //VARS
    public KeyCode interact;
    //REFS
    public HoneyTimer HT;

    public void ChangeJar()
    {
      //  if (Input.GetKeyDown(interact))
        //{
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
            HT.timerRunning = true;
            HT.timeRemaining = 10;
        //}

    }
}
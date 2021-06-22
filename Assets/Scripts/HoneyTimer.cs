using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyTimer : MonoBehaviour
{
    //VARS
    public float timeRemaining = 10;
    public bool timerRunning = false;
    public KeyCode interact;

    //REFS
    public TextMesh countdownText;
    public GameObject emptyJar;
    public GameObject fullJar;

    // Start is called before the first frame update
    void Start()
    {
        //Starts the timer automatically
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerRunning = false;
            }
        }

        if (timeRemaining == 0)
        {
            //the empty jar is child 0 and the full jar is child 1
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        
        // Mathf.FloorToInt returns the largest interger smaller to or equal to f.
        // the / makes the minutes
        // the % makes the seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

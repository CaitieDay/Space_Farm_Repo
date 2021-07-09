using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HoneyCollect : MonoBehaviour
{
    //VARS
    public Camera playerCamera;
    public float rayRange = 5f;
    public KeyCode interact;

    //DATA
    public Text dataTextJars;
    public int dataAmountJars = 0; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        dataTextJars.text = dataAmountJars.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Ray rayCast = playerCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit rayHit;

        if (Physics.Raycast(rayCast, out rayHit, rayRange))
        {
            if (rayHit.collider.tag == "Jars")
            {
                 if (Input.GetKeyDown(interact))
                 {
                    dataAmountJars++;
                    dataTextJars.text = dataAmountJars.ToString();
                    rayHit.collider.GetComponentInParent<HoneyTimer>().ChangeJar();
                 }
            }
        }
    }
}

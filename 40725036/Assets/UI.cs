using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject EscHome;
    public bool escBool;
    void Start()
    {
        EscHome.SetActive(false);
        escBool = false;
    }

    // Update is called once per frame
    void Update()
    {
        EscHomeSwitch();
        
    }
    public void EscHomeSwitch()
    {
        if (escBool == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                escBool = true;
                EscHome.SetActive(true);
            }
        }
        else if(escBool == true)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                escBool = false;
                EscHome.SetActive(false);
            }
 
        }
    }
    
}

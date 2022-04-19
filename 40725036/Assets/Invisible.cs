using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{
    public GameObject Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvisiblePlayer();
    }
    private void InvisiblePlayer()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Player.SetActive(true);
        }
    }
}

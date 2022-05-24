using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    
    public void SwitchGameScene()
    {
        SceneManager.LoadScene(1);
    }
    public void SwitchHomeScene()
    {
        SceneManager.LoadScene(0);
    }
}

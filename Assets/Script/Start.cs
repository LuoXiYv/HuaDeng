using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Next();
        }
    }

    public void Next()
    {
        SceneManager.LoadScene(1);
    }
}

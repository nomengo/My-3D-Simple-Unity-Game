﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
   public void ClickExit()
    {
        Application.Quit();
    }
    public void ReturnClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

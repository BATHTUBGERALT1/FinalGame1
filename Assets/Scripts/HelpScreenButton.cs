﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class HelpScreenButton : MonoBehaviour {

    public void HelpScreen()
    {
        //loads the main menu screen

        SceneManager.LoadScene("HomeScreen");


    }

}

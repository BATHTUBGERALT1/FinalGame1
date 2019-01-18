using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//uses the scene management feature
using UnityEngine.SceneManagement;
public class GoToHelp : MonoBehaviour {

    public void GoHome()
    {
        //loads my help screen
        SceneManager.LoadScene("HelpScreen");

    }
	
}

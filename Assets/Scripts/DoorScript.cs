﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// extra using statemet to allow us to use scene management functions
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{

    // variable to let us add to the score 
    // public so we can drag and drop 
    public TeaBag scoreObject;
    public Sugar SugarObject;
    public TeaBox TeaBoxObject;

    //designer variables 
    public string sceneToLoad;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        //check if the thing that we collided with 
        // is the player(has a player script)
        Player playerScript = collision.collider.GetComponent<Player>();

        // only do something if the thing we ran into 
        // was infact the player
        // akak playerscript is not null
        if (playerScript != null)
        {
            // we DID hit the player !!!!!!

            // save the score using our score object reference 
            scoreObject.SaveTeaBag();
          
            SugarObject.SaveSugar();

            TeaBoxObject.SaveTeaBox();
            //next level
            SceneManager.LoadScene(sceneToLoad);

        }

    }
}


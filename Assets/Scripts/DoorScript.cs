using System.Collections;
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

    
    public string sceneToLoad;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        //checks the playerscript has been collided with
        Player playerScript = collision.collider.GetComponent<Player>();

        // something only happens when the play is hit
        if (playerScript != null)
        {
            // we DID hit the player !!!!!!

            // saves the seperate scores 
            scoreObject.SaveTeaBag();
          
            SugarObject.SaveSugar();

            TeaBoxObject.SaveTeaBox();
            //goes to the high score screen
            SceneManager.LoadScene(sceneToLoad);

        }

    }
}


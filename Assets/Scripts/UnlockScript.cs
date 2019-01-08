using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockScript : MonoBehaviour
{
    //variable for adding to the score so we can drag and drop
    public Key scoreObject;

    //variable for the sugars value and so we can change it 
    public int keyValue;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    // this deletes the sugar on collision with the player

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // checks if the player actually collided with us 
        Player playerScript = collision.collider.GetComponent<Player>();

        // if we have touched something that has the player script
        // it is the player so we die

        if (playerScript)
        {

            //we have hit the sugar
            //add to our score
            scoreObject.AddScore(keyValue);
            //we have hit the player kill the object
            Destroy(gameObject);

        }

    }
}
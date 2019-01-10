using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using statement for the use of ui
using UnityEngine.UI;

public class TeaBag : MonoBehaviour
{

    // this makes the score visible and is able to be dragged and dropped within the editor

    public Text scoreText;

    //variable to track the score, and it is private so other scripts cant change it directly
    // starts at 0 as we dont have any when starting

    private int numericalScore = 0;

    // Use this for initialization
    void Start()
    {

        //got to have player prefs to save and access the data between sessions
        // pre set at 0 as we havent collected any sugar
        // adds to the numerical score 
        numericalScore = PlayerPrefs.GetInt("teabag", 0);

        //this will add to the visual score 
        scoreText.text = numericalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //function for adding to the score 
    // public so other things can use it e.g key 
    public void AddScore(int _toAdd)
    {
        //this adds to the numerical score
        numericalScore = numericalScore + _toAdd;

        //update the score visually 
        scoreText.text = numericalScore.ToString();

    }

    //function for saving the score, this will be public as it will need to be saved between levels 
    public void SaveTeaBag()
    {
        PlayerPrefs.SetInt("teabag", numericalScore);

    }

}
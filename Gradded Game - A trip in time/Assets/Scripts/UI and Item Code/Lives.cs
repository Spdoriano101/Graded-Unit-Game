using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{

    public Text livesText;
    public int numericalLives = 3;



    // Use this for initialization
    void Start()
    {
        //sets the total lives to 3 at the start of the game 
        numericalLives = PlayerPrefs.GetInt("Lives2", 3);  

        //ties the lives to teh main lives script
        livesText.text = numericalLives.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoseLife()
    {
        //takes away one life 
        numericalLives = numericalLives - 1;

        livesText.text = numericalLives.ToString();

       
    }

    public void saveLives()
    {

        PlayerPrefs.SetInt("Lives2", numericalLives);
    }

    //Variables detect wether game is over or not by detecting if lives are <= 0
    public bool IsGameOver()
   {

       if (numericalLives <= 0)
       {
    
           return true;

       }
     
        else
        {

           return false;

        }

    }
}

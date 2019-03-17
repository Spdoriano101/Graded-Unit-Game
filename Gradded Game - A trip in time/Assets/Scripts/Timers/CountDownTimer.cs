using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Extra using statement to allow us to use the scene management functions
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    //Designer Variables
    public string sceneToLoad;

    //sets variables to a specific value
    float currentTime = 0f;
    float startingTime = 260f;

    [SerializeField] Text countdownText;

    // Use this for initialization
    void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        //tells the program to countdown from the set value by 1 every second
        //once the timer reaches 0, it will not pass into teh negatives
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
   


    //states that when the eitme = 0 the game will finish and the player will be taken to the game over screen. 
        if(currentTime <= 0)
        {

            currentTime = 0;
            

            // load next level
            SceneManager.LoadScene(sceneToLoad);
        }






    }


    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    
    public string sceneToLoad;

    float currentTime = 0f;
    float startingTime = 150f;

    [SerializeField] Text countdownText;

  
    void Start()
    {
        //sets current time to starting time
        currentTime = startingTime;
    }

    private void Update()
    {
        //tells the program to countdown from the set value by 1 every second
        //once the timer reaches 0, it will not pass into the negatives
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
   


        //states that when the time = 0 the game will finish and the player will be taken to the game over screen. 
        if(currentTime <= 0)
        {

            currentTime = 0;
            

            // load next level
            SceneManager.LoadScene(sceneToLoad);
        }






    }


    
}


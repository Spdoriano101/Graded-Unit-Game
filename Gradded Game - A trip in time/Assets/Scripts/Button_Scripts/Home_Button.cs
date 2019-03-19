using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;



public class Home_Button : MonoBehaviour
{
    //This will be called by the button component
    // When the button is clicked
    public void StartGame()
    {
        
        
        //loads the start menu
        SceneManager.LoadScene("Start_Menu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;



public class Home_Button : MonoBehaviour
{
    
    public void StartGame()
    { 
        //loads the start menu
        SceneManager.LoadScene("Start_Menu");
    }
}


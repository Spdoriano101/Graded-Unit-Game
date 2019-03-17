using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Help_Screen : MonoBehaviour {

    public void startGame()
    {
        // loads the help screen from the main menu 
        SceneManager.LoadScene("Help_Scene");
    }
    
}

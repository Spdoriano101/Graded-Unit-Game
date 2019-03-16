using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_Button : MonoBehaviour {


    public void StartGame()
    {
        // This will load the help screen from the main menu 
        SceneManager.LoadScene("Main_Menu");
    }
}

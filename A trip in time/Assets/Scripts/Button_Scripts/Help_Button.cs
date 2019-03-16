using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Help_Button : MonoBehaviour {

    public void StartGame()
    {
        // This will load the help screen from the main menu 
        SceneManager.LoadScene("Help_Screen");
    }

}

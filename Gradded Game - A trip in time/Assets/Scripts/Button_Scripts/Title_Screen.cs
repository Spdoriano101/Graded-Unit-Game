using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_Screen : MonoBehaviour {

	
	public void startGame () {

        // loads the main menu screen form the help screen
        SceneManager.LoadScene("Start_Menu");

    }
	
	
}

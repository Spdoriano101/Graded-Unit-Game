using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character_Button : MonoBehaviour {

    // Sets the character choice variable to a static string, allowing it to be read over multiple scripts
    public static string characterChoice = "";

    // sets scene to load to a string that can also, again, be accessed from other scripts
    public string sceneToLoad = "";

   

    public void SelectCharacter(string chosenCharacter)
    {
        // Deletes the Lives and the score when the selected button is pressed 
        PlayerPrefs.DeleteKey("Lives2");
        Score.ResetScore();

        // Sets the variable character 
        characterChoice = chosenCharacter;

        //loads the first scene
        SceneManager.LoadScene(sceneToLoad);

    }
}

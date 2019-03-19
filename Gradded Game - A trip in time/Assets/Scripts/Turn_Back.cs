using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class Turn_Back : MonoBehaviour
{

    public bool textDisplay;
  
    //public string Text = "Turn Back";

    //Allows for the box that the text is in to be changed
    public Rect BoxSize = new Rect(0, 0, 200, 100);

   
    // if this script is on an object with a collider display the Gui
    void OnTriggerEnter()
    {
        textDisplay = true;
    }

    // if this script is on an object with a collider do not #display the Gui
    void OnTriggerExit()
    {
        textDisplay = false;
    }

   

}

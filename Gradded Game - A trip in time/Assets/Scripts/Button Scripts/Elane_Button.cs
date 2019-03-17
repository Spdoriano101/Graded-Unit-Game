using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class GloablVariables
{
    //Sets the character choice variable
    public static bool characterChoice;

}

public class Elane_Button : MonoBehaviour {
   

    void Start()
    {
        //Deletes the main lives count
        PlayerPrefs.DeleteKey("Lives");

        if (GloablVariables.characterChoice == true)
        {
            // checks to see what character was chosen and deletes the one that was not.
            Destroy(gameObject);

        }

    }

 
}


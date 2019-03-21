using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {



	void Update () {

        //This is used for when the game is built, by pressing the ESC key the player can exit the game if it freezes or 
        //needs to back out
		if (Input.GetKey("escape"))
        {

            Application.Quit();

        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Extra using statement to allow us to use the scene management functions
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

    //VAriable to let us add to the score
    //Public so we can drag and drop
    public Score scoreObject;

    //Designer Variables
    public string sceneToLoad;

    // Unity cals this function automatically
    // when our spikes touch any other object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the thing that collded with 
        // is the player (aka has a Player script)
        Player playerScript = collision.collider.GetComponent<Player>();

        // Only do somehting if the thing we ran into
        // was in fact the player
        // aka playerscript is not null

        if (playerScript != null)
        {

            // hit the player!

            //save the score using our score object reference 
            scoreObject.SaveScore();

            // load next level
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

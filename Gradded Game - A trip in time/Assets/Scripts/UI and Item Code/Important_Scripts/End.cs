using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

   
    public Score scoreObject;

    public string sceneToLoad;

   // collision detection
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // check if asset that collided has player script
        Player playerScript = collision.collider.GetComponent<Player>();

        // if collided with the asset
        if (playerScript != null)
        {

            //save the score using our score object reference 
            scoreObject.SaveScore();

            // load next level
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Level : MonoBehaviour {
  

    public string sceneToLoad;

    public Score scoreObject;

    //Unity automaticall calls the function to detect collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // checks if player script is attached to asset
        Player playerScript = collision.collider.GetComponent<Player>();

       //states that if the player does hit something
        if (playerScript != null)
        {

            //saves score of that level
            scoreObject.SaveScore();

            // load next level
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

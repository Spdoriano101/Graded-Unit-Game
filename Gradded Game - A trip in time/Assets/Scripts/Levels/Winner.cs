using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    
    //detects collsioion 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // detects if assets collided has the player script attached
        Player playerScript = collision.collider.GetComponent<Player>();

    
        //if the asset has been collided with then...
        if (playerScript != null)
        {

        //load next level - specifically the winner scene
            SceneManager.LoadScene("Winner");
        }
    }
}

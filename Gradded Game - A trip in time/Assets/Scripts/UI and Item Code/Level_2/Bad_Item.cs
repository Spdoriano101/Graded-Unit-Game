using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad_Item : MonoBehaviour
{

    //Setting the audio source 

    public Score scoreObject;

    public AudioSource Audio;

    
    void Start()
    {

        



    }


    //Unity calls this function when Item touches any other object in the game
    // If the player touched the Item, it should vanish and the score should increase
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Check if the object that collided with the item was the player
        Player playerScript = collision.collider.GetComponent<Player>();
       

        //If the player collides with an object or asset(s) that 
        //Have a playerscript attached to it
        if (playerScript)
        {

            Audio.Play();


            Score.scoreValue -= 70;
            // Destroy the gameObject that this script is attracted to
            



            Destroy(gameObject);
        }
    }
}



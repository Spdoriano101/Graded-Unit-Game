using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad_item_2 : MonoBehaviour {


    public Score scoreObject;

    public AudioSource Audio;

  
    void Start()
    {


    }

    //collision detection
    private void OnCollisionEnter2D(Collision2D collision)
    {
  
        Player playerScript = collision.collider.GetComponent<Player>();


       
        if (playerScript)
        {
            //audio to play when the assets with the player scirpt is collided with
            Audio.Play();


            Score.scoreValue -= 70;
            // Destroy the gameObject that this script is attacted to
         



            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item: MonoBehaviour {

 
    public Score scoreObject;

    public AudioSource Audio;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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


            Score.scoreValue += 50;
            // Destroy the gameObject that this script is attacted to
           



            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    [Range(1, 100)]
    public float jumpVelocity;

    public Collider2D playerCollider;
   

    // Update is called once per frame
    void Update () {

        // Jumping

        //Detect sprite touching the ground
        //Get the LayerMask from Unity using the name of the layer
        LayerMask groundLayerMask = LayerMask.GetMask("Ground");

        //Ask the player's collider if it is touching the LayerMask
        bool touchingGround = playerCollider.IsTouchingLayers(groundLayerMask);





        //Detects wethe if th eplayer is touching the ground 
        if (Input.GetButtonDown("Jump") && touchingGround == true)
        {

            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;


        }



    }
}

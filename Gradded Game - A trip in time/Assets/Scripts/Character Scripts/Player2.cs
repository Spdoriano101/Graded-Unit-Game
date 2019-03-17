using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

    // designer variables
    public float speed = 7;
    public float jumpSpeed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";
    public string jumpButton = "Jump";


    public Animator playerAnimator;
    public SpriteRenderer playerSprite;
    public Collider2D playerCollider;

    // Use this for initialization
    void Start()
    {

    }


    void Update()
    {

        // Get axis input from Unity
        float leftRight = Input.GetAxis(horizontalAxis);


        // Create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, 0);

        // Make direction vector length 1
        direction = direction.normalized;

        // Calculate velocity
        Vector2 velocity = direction * speed;

        // preserve vertical velocity from physics
        velocity.y = physicsBody.velocity.y;

        // Give the velocity to the rigidbody
        physicsBody.velocity = velocity;



        //Flip the sprite when moving backwards/opposite way
        if (velocity.x < 0)
        {
            playerSprite.flipX = true;
        }
        else
        {
            playerSprite.flipX = false;
        }


        //Animation for the animator script
        playerAnimator.SetFloat("Walk", Mathf.Abs(leftRight));

        // Jumping

        //Detect sprite touching the ground
        //Get the LayerMask from Unity using the name of the layer
        LayerMask groundLayerMask = LayerMask.GetMask("Ground");

        //Ask the player's collider if it is touching the LayerMask
        bool touchingGround = playerCollider.IsTouchingLayers(groundLayerMask);

        //Detects input of jump button
        bool jumpButtonPressed = Input.GetButtonDown(jumpButton);

        if (jumpButtonPressed == true && touchingGround == true)
        {
            //pressed Jump so should set upward velocity to jumpSpeed
            velocity.y = jumpSpeed;

            //Give the velocity to the rigidbody
            physicsBody.velocity = velocity;
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check the thing we bump into is an enemy
        if (collision.collider.GetComponent<Enemy>())
        {
            // die
            Destroy(gameObject);
        }
    }

}


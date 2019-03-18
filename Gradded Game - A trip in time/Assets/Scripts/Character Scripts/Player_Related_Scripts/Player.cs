using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Extra using statement to allow the use scene management functions
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    // designer variables
    public float speed = 7;
    public float jumpSpeed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";
    public string jumpButton = "Jump";

    public Animator playerAnimator;
    public SpriteRenderer playerSprite;
    public Collider2D playerCollider;

    public AudioSource Death;
    public AudioSource Item_pickup;

    public Lives livesObject;


    // Use this for initialization
    void Start()
    {
        if (Character_Button.characterChoice != name)
        {
            //it says that the characterChoice isn't our character
            Destroy(gameObject);
        }
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

       
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        

        // Check the thing we bump into is an enemy
        if (collision.collider.GetComponent<Enemy>())
        {
            //Take away a life and save that change
            livesObject.LoseLife();
            livesObject.saveLives();

            Death.Play();
            


            //Check if its game over

            bool gameOver = livesObject.IsGameOver();

            if (gameOver == true)
            {
                //If it IS game over...
                //Load the game over scene

                SceneManager.LoadScene("Game_Over");

            }

            else
            {
                //try and fix this you need to try and get the game to take away a life but not reset 
                //but still check to see if the gme is over and the get the game to reset


                //If it is NOT game over...
                //reset the current level to restart from the begining

                // Reset the current level to restart from the begining.

                //First, ask untiy what the current level is 

                Score.scoreValue = PlayerPrefs.GetInt("score", 0);


                Scene currentLevel = SceneManager.GetActiveScene();

                //Second, tell unity to load the current again
                // by passing the build index of our level
                

                SceneManager.LoadScene(currentLevel.buildIndex);


            }
        }
    }
}




        
 



  







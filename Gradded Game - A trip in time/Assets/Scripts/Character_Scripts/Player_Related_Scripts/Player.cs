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


 
    void Start()
    {
        if (Character_Choice.characterChoice != name)
        {
            //Detects the character that wasnt picked in the level and destroys it
            //This happens for every level the player visits
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
        
        // Detects if the object/assets that was collided with holds the "Enemy" script
        if (collision.collider.GetComponent<Enemy>())
        {
            //Take away a life and save that change
            livesObject.LoseLife();
            livesObject.saveLives();

            //Plays the death sound
            Death.Play();
            
            //Checks if its game over
            bool gameOver = livesObject.IsGameOver();

            if (gameOver == true)
            {
         
                //If it IS game over, load the game over scene
                SceneManager.LoadScene("Game_Over");

            }

            else
            {
                //Detects what the current score of the player is
                Score.scoreValue = PlayerPrefs.GetInt("score", 0);

                //Detects what level the player is on and saves it
                Scene currentLevel = SceneManager.GetActiveScene();

              //Relods the saved level, from the start point of that level
              //using the build index
                SceneManager.LoadScene(currentLevel.buildIndex);


            }
        }
    }
}




        
 



  







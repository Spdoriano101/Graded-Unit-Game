using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour {

    //COntainer for the rigid body
    private Rigidbody2D myRigidbody;

    private Animator myAnimator;

    [SerializeField]
    private float movementSpeed;

    private bool facingRight;

	// Use this for initialization
	void Start () {

        //always starts game facing right
        facingRight = true;

        //Reference to the players rigidbody
        myRigidbody = GetComponent<Rigidbody2D>();

        myAnimator = GetComponent<Animator>();
	}
	
	//Keeps the movment of the player constant reguardless of FPS
	void FixedUpdate () {

        float horizontal = Input.GetAxis("Horizontal");
        
        //Calls the handleMovement function to use and also links the "Horizontal" data to the HandleMovement function
        HandleMovement(horizontal);

        //Detects what way the player should face before running script
        Flip(horizontal);

	}

    //Sets the players movement
    private void HandleMovement(float horizontal)
    {
        //Controls the speed of the characater movement
        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);

        myAnimator.SetFloat("Speed", Mathf.Abs(horizontal));

    }

    //Function used to flip the character
    private void Flip(float horizontal)
    {

        //WHen the horizontal is greater than 0, face right, if not and less than 0, face left
        if (horizontal > 0  && !facingRight || horizontal < 0 && facingRight)
        {

            //Will make it false when its true and vice versa, controlling the value
            facingRight = !facingRight; 

            //Multipling the scale, so if -1 * 1 = -1 then the player will face left as left is 
            //on the negative and if -1 * -1 = 1 then the player will face right as this is on the positive
            //"theScale" is the scale of the player
            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;

        }

    }
}

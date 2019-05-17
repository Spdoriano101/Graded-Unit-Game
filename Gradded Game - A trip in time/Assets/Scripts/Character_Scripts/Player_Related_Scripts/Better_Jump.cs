using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Better_Jump : MonoBehaviour {

    //This will set the value of the multipiler when the character falls
    public float fallMultiplier = 1.5f;
    public float lowJumpMultiplier = 1.5f;

 
    //reference to the rigidbody
    Rigidbody2D rb;

    //sets the rigidbody to "rb"
    void Awake() {

        rb = GetComponent<Rigidbody2D>();
    }

    //calculates the fall multiplier to give a better jump feel
    private void Update()
    {
       
        //for when the character is falling, applies the multiplier 
            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            }

        //checks to see if the player is jumping up and if the player is still holding the jump button
            else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
            {

                rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            }
        }
    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Better_Jump : MonoBehaviour {

    public float fallMultiplier = 1.5f;
    public float lowJumpMultiplier = 1.5f;

 

    Rigidbody2D rb;

    void Awake() {

        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
       

            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            }
            else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
            {

                rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            }
        }
    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
    
    //These variables are public as they will be used by other functions 
    public float speed;
    public float distance;
    public Transform groundDetection;

    private bool movingRight = true;

    void Update()
    {
        //States the way in which the emeny must move
        //delta time wil be used to smooth out the movement of the character 
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        //This will fire a ray downwards to detect when the collider ends and allows for  detection to take place
        //the brackets contain the information for the origin of the ray, the direction that the ray will be traveling in
        //and the distance that it will travel
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

        // This will check if the ray has collided with anything
        if (groundInfo.collider == false)
        {
            //Checks if the character was moving right, and if so
            //will pivot the character 180 to move in the oppostie direction
            if (movingRight == true)
            { 
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }

            //This will fli the character again once it has reacted the other edge
            //and the ray has detected that there is no more collider
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;

            }

        }
    }

}

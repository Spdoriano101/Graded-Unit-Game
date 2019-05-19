using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {


    public Transform followTarget;
    public float cameraDistance = 30.0f;
    public GameObject Player;

    void Start()
    {
        //Finds the player and sets player to the found player GameObject
        Player = GameObject.Find(Character_Choice.characterChoice);

        //Stores player.transform in follow target 
        followTarget = Player.transform;

    }

    // Update is called once per frame
    void FixedUpdate()

    {
        // Sets the position of the camera to match the screen size and shape
        transform.position = new Vector3(followTarget.position.x, followTarget.position.y, transform.position.z);

    }
 }





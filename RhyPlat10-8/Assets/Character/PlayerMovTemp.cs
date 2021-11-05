using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovTemp : MonoBehaviour
{
    // OUTSIDE OF START
    // declare float variables for (public)SPEED, (public)JUMPFORCE, and (private)MOVEINPUT
        // does exactly what they're called
    // declare Rigidbody2D variable

    // create bool var that determines if the character is face a direction, left OR right and set it to true

    // create bool car to check if player is touching the ground

    void Start()
    {
        // assign rigidbody to a getcomponent
    }

    void FixedUpdate()  // FixedUpdate doesnt depend on fps; runs at 50-60Hz whereas Update runs every frame
    {
        // assign moveinput to an Input.GetAxis to the keys we want for horizontal movement
        // assign out rigidbody variable with velocity method and create new vector2, passing out moveinput variable, multiplied by speed
        // and our rigid body's unaffected y variable.

        // check if our moving direction contradicts our facing direction, if it does, then run flip method
    }

    // create a method that inverts out bool variable for facing direction
    // use scaler declared by the player's localscale
    // invert our x by multiplying by -1
    // set the player's local scale to our now inverted scaler

}

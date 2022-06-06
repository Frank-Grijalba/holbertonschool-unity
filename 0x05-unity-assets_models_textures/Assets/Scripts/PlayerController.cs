using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Serialization;

public class PlayerController : MonoBehaviour
{
    // variables for x-axis and y-axis, x = horizontal, z = vertical
    private float Horizontal;

    private float Vertical;
    public float speed;
    public float jump;
    private float gravityValue = 9.81f;

    private UnityEngine.CharacterController player;

    void Start ()
    {
        player = GetComponent<CharacterController> ();
    }

    void update ()
    {
    }


    void FixedUpdate()
    {
        // GetAxis take the value of the mouse too,Typically a positive value means the mouse is moving 
        // right/down and a negative value means the mouse is moving left/up.
        //Input.GetAxis("Mouse X") and  Input.GetAxis("Mouse Y") to move in the vector in X and Z
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(Horizontal, 0.0f, Vertical);
        player.Move(move * speed * Time.deltaTime);

        // value keyboard Space
        if (Input.GetKey(KeyCode.Space))
        {
            player.Move(new Vector3(0, gravityValue * jump * Time.deltaTime, 0));
        }
    }
} 
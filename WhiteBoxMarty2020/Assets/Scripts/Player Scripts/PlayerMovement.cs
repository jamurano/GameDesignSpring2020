﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    public CharacterController controller;
    
    public float speed = 12f;
    public float dashSpeed = 25f;
    public float runSpeed = 20f;
    public float gravity = -9.81f; 
    public float jumpHeight = 3f;
    
    public Transform groundCheck; 
    public float groundDistance = 0.4f;

    private Vector3 velocity;
    public bool isGrounded;
    public bool isClimbing;
    public bool isDashing;
    public bool isRunning;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance);
        float x = Input.GetAxis("Horizontal"); 
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(0,0,0);
        if (isClimbing == false)
        {
            move = new Vector3(-x, 0, -z);
            if (x != 0 || z != 0)
            {
                transform.rotation = Quaternion.LookRotation(move);
            }
        }

        else
        {
            move = new Vector3(-x,z, 0);
        }

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift) && isGrounded)
        {
            isRunning = !isRunning;
        }

        if (isRunning)
        {
            controller.Move(move * runSpeed * Time.deltaTime);
        }
        
        if (Input.GetButtonDown("Jump") && isGrounded) 
        {
            velocity.y = jumpHeight; 
        }

        if (isClimbing == false)
        {
            velocity.y += gravity * Time.deltaTime;
            
            controller.Move(velocity * Time.deltaTime);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Climbable")
        {
            isClimbing = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Climbable")
        {
            isClimbing = false;
        }
    }
}

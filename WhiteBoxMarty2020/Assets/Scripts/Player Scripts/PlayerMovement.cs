using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    public CharacterController controller;
    
    public float speed = 12f;
    public float runSpeed = 20f;
    public float gravity = -9.81f; 
    public float jumpHeight = 3f;

    public Transform groundCheck; 
    public float groundDistance = 0.4f;

    private Vector3 velocity;
    public bool isGrounded;
    public bool isClimbing;
    public bool isRunning;

    public LayerMask ground;
    
    void Update()
    {
        //Checks to see if player is touching the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, ground);
        float x = Input.GetAxis("Horizontal"); 
        float z = Input.GetAxis("Vertical");

        // normal movement if not climbing
        Vector3 move = new Vector3(0,0,0);
        if (isClimbing == false)
        {
            move = new Vector3(-x, 0, -z);
            if (x != 0 || z != 0)
            {
                transform.rotation = Quaternion.LookRotation(move);
            }
        }

        //otherwise switch W and S to up and down to climb
        else
        {
            move = new Vector3(-x,z, 0);
        }
        
        controller.Move(move * speed * Time.deltaTime);
       
        //if player holds down rightShift, they will run
        if (Input.GetKey(KeyCode.RightShift) && isGrounded)
        {
            isRunning = !isRunning;
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

    //Climbing trigger
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

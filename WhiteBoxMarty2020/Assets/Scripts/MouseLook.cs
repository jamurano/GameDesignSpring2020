using UnityEngine;

public class MouseLook : MonoBehaviour
{
     public float mouseSensitivity = 100f;
 
     public Transform playerBody;
 
     private float xRotation = 0f;
     void Start()
     {
         Cursor.lockState = CursorLockMode.Locked;
     }
     
     void Update()
     {
         float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
         
         transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
         playerBody.Rotate(Vector3.up * mouseX);
     }
 }


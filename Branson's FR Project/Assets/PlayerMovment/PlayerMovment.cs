using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{ 

   public CharacterController controller;

   public float speed = 12f;
   public bool isMoving = false;

   public float gravity = -9.81f;
   public float jumpHeight = 3f;

   public Transform groundCheck;
   public float groundDistance = 0.4f;
   public LayerMask groundMask;

   public float orginalHeight, crouchHeight;

   Vector3 velocity;
   bool isGrounded;
     
    void Update()
    {
     // Checks to see if the character is colliding with the ground or not
      isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
      
      if(isGrounded && velocity.y < 0)
      {
         velocity.y = -2f;
      }
      // Moves in the direction of the camera
      float x = Input.GetAxis("Horizontal");
      float z = Input.GetAxis("Vertical");

      Vector3 move = transform.right * x + transform.forward * z;

      controller.Move(move * speed * Time.deltaTime);

      // Should Sprint
      if(Input.GetButtonDown("W"))
      {
         isMoving = true;
      }
      
      if(Input.GetKeyUp("W"))
      {
         isMoving = false;
      }

      if(Input.GetKey(KeyCode.LeftShift) & isMoving ==true)
      {
         transform.position += transform.forward * Time.deltaTime * speed
      }
      //Should Jump
      if(Input.GetButtonDown("Jump") && isGrounded)
      {
         velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
      }

      velocity.y += gravity * Time.deltaTime;

      controller.Move(velocity * Time.deltaTime);
      // Should Crouch character
     }
     if(Input.GetKeyDown(KeyCode.LeftControl))
     {
         controller.height = crouchHeight;
     }
     if(Input.GetKeyUp(KeyCode.LeftControl))
     {
         controller.height = orginalHeight;
     }
}
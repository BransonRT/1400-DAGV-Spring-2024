using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{ 
    [SerializeField]private float moveSpeed=5f;
    [SerializeField] private float jumpForce=5f;
    [SerializeField] private float gravity=9.81f;

    [SerializeField] private float rotationSpeed = 100f;
    private CharacterController characterController;
    private Vector3 moveDirection;
    private bool isJumping;
     void Start()
     {
        characterController = GetComponent<CharacterController>();
     }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        moveDirection=transform.forward*horizontalInput;
        moveDirection=transform.forward*verticalInput;

        float rotation = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotation);

        if(characterController.isGrounded && Input.GetButtonDown("Jump"));

        moveDirection.y-=gravity*Time.deltaTime;
    
        if(isJumping=true, moveDirection.y=jumpForce);
     else
        {
            characterController.isGrounded;
        }
     }
    

}
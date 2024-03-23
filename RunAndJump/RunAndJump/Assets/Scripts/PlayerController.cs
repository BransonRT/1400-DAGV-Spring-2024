using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent <Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        
       
    }

    // Update is called once per frame
    void Update()
    {//Player movement and jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
             playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
             isOnGround = false;
             playerAnim.SetTrigger("Jump_trig");

        }
    } 
    private void OnCollisionEnter(Collision collision)
    {//If the player is touching the ground then the game will continue
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }// if the player touches the obstacle then it reads a game over
        else if(collision.gameObject.CompareTag("Obstacle"))
            {
                Debug.Log("Game Over");
                gameOver = true;
            }
        
    }
}

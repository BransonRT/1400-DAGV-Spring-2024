using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    private AudioSource playerAudio;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent <Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;
        
       
    }

    // Update is called once per frame
    void Update()
    {//Player movement and jump/ also if player dies they won't be able to jump. Dirt particles have been added
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
             playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
             isOnGround = false;
             playerAnim.SetTrigger("Jump_trig");
             dirtParticle.Stop();
             playerAudio.PlayOneShot(jumpSound, 1.0f);

        }
    } 
    private void OnCollisionEnter(Collision collision)
    {//If the player is touching the ground then the game will continue
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }// if the player touches the obstacle then it reads a game over
        else if(collision.gameObject.CompareTag("Obstacle"))
            {// Plays a death animation and particle explosion when conditions are met
                Debug.Log("Game Over");
                gameOver = true;
                playerAnim.SetBool("Death_b", true);
                playerAnim.SetInteger("DeathType_int", 1);
                explosionParticle.Play();
                dirtParticle.Stop();
                playerAudio.PlayOneShot(crashSound, 1.0f);
            
            }
        
    }
}

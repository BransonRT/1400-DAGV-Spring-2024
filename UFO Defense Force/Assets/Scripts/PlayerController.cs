using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;

    public Transform blaster;
    public GameObject lazer;
    public bool hasPowerup;
    public int powerUpDuration=5;

    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();//Reference GameManager class
    }

    // Update is called once per frame
    void Update()
    {
        // Set HorizontalInput to recive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        //Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //Keep player within bounds
        // Left Side Wall
        if(transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Right Side Wall
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        } 
        // if spacebar is pressed. Fire the lazer
        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)//Second condition makes it where if the game is over you can't fire anymore
        {
            //Create laser at the blaster transform position maintaining the objects rotation
            Instantiate(lazer, blaster.transform.position, lazer.transform.rotation);
        }
       
    }

    // Delete any object with a trigger that hits the player
     private void OnTriggerEnter(Collider other)
     {
        if(other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountdownRoutine());
        }
        //Destroy(other.gameObject);
        IEnumerator PowerUpCountdownRoutine()
        {
            yield return new WaitForSeconds(5);
            hasPowerup=false;
        }
     }

}

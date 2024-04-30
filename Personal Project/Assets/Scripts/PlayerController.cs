using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    private float speed = 10.0f;
    private float zBound= 8;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();

        void MovePlayer()
        {
        // Allows player to move with default keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //Player speed
        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
        }

        void ConstrainPlayerPosition()
        {
        //Invokes a boundary that the player can't cross
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        /// void OnCollisionEnter(Collision collision)
        {
        ///if(OnCollisionEnter.gameObject.CompareTag("Enemy"))
        ///{
            ///Debug.log("Got hit");
        ///}

        }
    
    }
}
}

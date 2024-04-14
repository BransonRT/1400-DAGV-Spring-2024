using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public float speed = 5.0f;
    public bool hasPowerup = false;


    // Start is called before the first frame update
    void Start()
    {//finds the focal point game object
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {// Moves the the player on the vertical axis
      float forwardInput = Input.GetAxis("Vertical");

      playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);  
    }
    private void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Powerup"))
      {
          hasPowerup = true;
          Destroy(other.gameObject);
      }

    }
    private void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
      {
        Debug.Log("Collided with: " + collision.gameObject.name + " with powerup set to" + hasPowerup);
      }
    }
}

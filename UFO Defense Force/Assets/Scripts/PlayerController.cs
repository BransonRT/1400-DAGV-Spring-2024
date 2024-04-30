using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;


    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}

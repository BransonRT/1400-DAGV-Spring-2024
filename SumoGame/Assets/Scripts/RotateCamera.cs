using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float roationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {// Rotates camera on the Horizontal Axis when side keys are pressed. The side keys control the camera rotation onlt
       float horizontalInput= Input.GetAxis("Horizontal");
       transform.Rotate(Vector3.up, horizontalInput * roationSpeed * Time.deltaTime); 
    }
}

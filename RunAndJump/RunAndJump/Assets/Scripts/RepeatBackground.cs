using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{   
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {//Box colider and starting position of the background
        startPos = transform.position;
        repeatWidth =  GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {//Resets the background as soon as it exceeds a certain distance.
        if (transform.position.x < startPos.x - repeatWidth)
         {
            transform.position = startPos;
         }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {// Tells the Box Collider to destroy both the projectile and the Game object it hits if the collider box triggers
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionDetect : MonoBehaviour
{
  
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);//Destroy this gameobject
        Destroy(other.gameObject);//destroy the other game object it hits
    }

}

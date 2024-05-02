using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionDetect : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager

    public int scoreToGive;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager gameobject and reference ScoreManager script component
    } 
  
    void OnTriggerEnter(Collider other) // Once the Trigger has been entered record collision in the argument variable "other"
    {
        scoreManager.IncreaseScore(scoreToGive); // Increase the score
        Destroy(gameObject);//Destroy this gameobject
        Destroy(other.gameObject);//destroy the other game object it hits
    }

}

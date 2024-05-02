using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public GameManager gameManager;
    public float topBounds = 40.0f;
    public float lowerBounds = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Awake()
    {
        ///Time.timescale =1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over");
            gameManager.isGameOver = true;
            Destroy(gameObject);
            

            ///Time.timeScale0 = 0;
        }
    }
    
}

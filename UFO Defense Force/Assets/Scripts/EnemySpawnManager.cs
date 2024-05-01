using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs;//Array to store UFO ships
    private float spawnRangeX = 20f;
    private float spawnPosZ= 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if(Input.GetKeyDown(KeyCode.S))
        {   
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
             int ufoIndex = Random.Range(0,ufoPrefabs.Length);//Picks a random UFO from the array
             Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation);//Spawns a indexed UFO from the array
        } 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] powerup;
    private float zEnemySpawn = 12.0f;
    private float xSpawnBound= 16.0f;
    private float zPowerupRange= 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        ///int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnpos = new Vector3(randomX, ySpawn, zEnemySpawn);

        Instantiate(enemies, spawnpos, enemies.gameObject.transform.rotation);
    }
}

using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{

    public List<GameObject> enemyPrefabs = new List<GameObject>();

    public float timer = 0;
    public float spawnRate = 5;

    public float xMin = -8f;
    public float xMax = 8f;
    public float ySpawn = 6f;

    void Start()
    {
        timer = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnMultipleEnemies();
            timer = spawnRate;


        }

    }

    public void SpawnRandomEnemy()
    {
        int randomI = Random.Range(0, enemyPrefabs.Count);
        GameObject randomEnemy = enemyPrefabs[randomI];

        Vector3 spawnPos = new Vector3(Random.Range(xMin, xMax), ySpawn, 0);
        Instantiate(randomEnemy, spawnPos, Quaternion.identity);
    }
    public void SpawnMultipleEnemies()
    {
        for (int i = 0; i < 4; i++)
        {
            SpawnRandomEnemy();
        }
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float minSpawnTime = 12f;
    public float maxSpawnTime = 20f;

    void Start()
    {
        Invoke("Spawner", Random.Range(minSpawnTime, maxSpawnTime));
    }

    void Spawner()
    {
        GameObject randomEnemy = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        Instantiate(randomEnemy, transform.position, transform.rotation);

        float nextSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        Invoke("Spawner", nextSpawnTime);
    }
}


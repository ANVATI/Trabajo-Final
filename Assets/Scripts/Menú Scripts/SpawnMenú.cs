using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMenú : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    void Start()
    {
        Invoke("Spawner", 4);
    }

    void Spawner()
    {
        GameObject randomEnemy = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        Instantiate(randomEnemy, transform.position, transform.rotation);
        Invoke("Spawner", 4);
    }
}

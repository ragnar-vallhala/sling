using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] private uint enemyCount = 0;
    [SerializeField] private float lastEnemy = 0.0f;
    [SerializeField] private float enemySpawnRate = 0.5f;



    void Update()
    {
        if ((Time.time - lastEnemy) > 1.0 / enemySpawnRate)
        {
            lastEnemy = Time.time;
            enemyCount++;

            
            enemyCount++;

            Vector3 spawnPoint = new Vector3(Random.Range(-8.5f, 8.5f), 5.0f,0.0f);
            Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);


        }

    }
}

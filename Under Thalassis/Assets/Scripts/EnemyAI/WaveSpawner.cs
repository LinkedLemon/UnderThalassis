using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private GameObject EnemyChaserPrefab;
    [SerializeField] private GameObject EnemyStrightPrefab;
    private EnemyScript EnemyManager;
    [SerializeField] private int timer = 500;

    private void Start()
    {
        EnemyManager = GameObject.Find("EnemyController").GetComponent<EnemyScript>();
    }

    private void AddChaserEnemy()
    {
        Instantiate(EnemyChaserPrefab, gameObject.transform);
    }
    private void AddStrightEnemy()
    {
        Instantiate(EnemyStrightPrefab, gameObject.transform);
    }
void Update()
    {
        timer--;

        if (timer < 0)
        {
            int enemyWeight = Random.Range(10, 20);

            if (enemyWeight >= 18 && EnemyManager.enemyCount < 10)
            {
                AddStrightEnemy();
            }
            else if (enemyWeight <= 15 && EnemyManager.enemyCount < 10)
            {
                AddChaserEnemy();
            }
            timer = 500;
        }
    }
}

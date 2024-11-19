using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyChaserPrefab;
    [SerializeField] private GameObject enemyStrightPrefab;
    [SerializeField] private int maxEnemyCount;
    private EnemyScript enemyManager;
    [SerializeField] private int timer = 500;

    private void Start()
    {
        enemyManager = GameObject.Find("EnemyController").GetComponent<EnemyScript>();
    }

    private void AddChaserEnemy()
    {
        Instantiate(enemyChaserPrefab, gameObject.transform);
    }
    private void AddStrightEnemy()
    {
        Instantiate(enemyStrightPrefab, gameObject.transform);
    }
void Update()
    {
        timer--;

        if (timer < 0)
        {
            int enemyWeight = Random.Range(0, 20);

            if (enemyWeight > 10 && enemyManager.enemyCount < maxEnemyCount)
            {
                AddStrightEnemy();
            }
            else if (enemyWeight < 10 && enemyManager.enemyCount < maxEnemyCount)
            {
                AddChaserEnemy();
            }
            timer = 500;
        }
    }
}

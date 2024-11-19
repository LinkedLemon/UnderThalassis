using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int enemyCount = 0;

    public void AddToCount()
    {
        enemyCount++;
    }

    public void RemoveToCount()
    {
        enemyCount--;
    }
}

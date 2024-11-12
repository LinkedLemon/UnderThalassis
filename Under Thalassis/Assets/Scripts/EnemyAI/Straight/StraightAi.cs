using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightAi : MonoBehaviour
{
    public float speed = 5.0f;
    [SerializeField] private HealthManager healthManager;
    [SerializeField] private int spawnAmount;
    [SerializeField] private GameObject Child;
    private GameObject EnemyController;
    private GameObject targetDirection;
    Vector3 direction;
    void Start()
    {
        targetDirection = GameObject.Find("Player");
        EnemyController = GameObject.Find("EnemyController");
        EnemyController.GetComponent<EnemyScript>().AddToCount();

        if (targetDirection != null)
        {
            transform.up = targetDirection.transform.position - transform.position;

            direction = (targetDirection.transform.position - transform.position).normalized;
            healthManager.isSpawner = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    public void SpawnChilds()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            Debug.Log("Added");
            var obj = Instantiate(Child);

            obj.transform.position = gameObject.transform.position;
            obj.transform.up = transform.up;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class ChaseAi : MonoBehaviour
{

    private GameObject player; // Reference to the player's transform
    private GameObject EnemyController;
    public float speed = 5f; // Speed at which the AI will chase the player
    public float stoppingDistance = 1f; // Distance at which the AI will stop chasing
    [SerializeField] private HealthManager healthManager;
    [SerializeField] private GameObject healthPickup;
    [SerializeField] private GameObject ammoPickup;

    private void Start()
    {
        player = GameObject.Find("Player");
        EnemyController = GameObject.Find("EnemyController");
        EnemyController.GetComponent<EnemyScript>().AddToCount();
        speed = speed + Random.Range(-1.2f, 1.5f);
    }
    void Update()
    {
        if (player != null)
        {
            // Calculate the distance between AI and player
            float distance = Vector3.Distance(transform.position, player.transform.position);

            // If the AI is farther away than the stopping distance, move towards the player
            if (distance > stoppingDistance)
            {
                // Calculate the direction towards the player
                Vector3 direction = (player.transform.position - transform.position).normalized;

                // Move the AI towards the player
                transform.position += direction * speed * Time.deltaTime;

                // Optionally, make the AI face the player
                transform.up = player.transform.position - transform.position;
            }
        }
    }

    public void SpawnPickup()
    {
        int random = Random.Range(0, 2);

        if (gameObject.name != "Player")
        {
            if (random == 0)
            {
                var pickup = Instantiate(ammoPickup);
                pickup.transform.position = transform.position;
            }
            else if (random == 1)
            {
                var pickup = Instantiate(healthPickup);
                pickup.transform.position = transform.position;
            }
            else if (random == 2)
            {
                return;
            }
        }
    }
            
}

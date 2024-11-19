using UnityEngine;

public class StraightAi : MonoBehaviour
{
    private float speed = 5.0f;
    [SerializeField] private HealthManager healthManager;
    [SerializeField] private int spawnAmount;
    [SerializeField] private GameObject child;
    private GameObject enemyController;
    private GameObject targetDirection;
    Vector3 direction;
    void Start()
    {
        targetDirection = GameObject.Find("Player");
        enemyController = GameObject.Find("EnemyController");
        enemyController.GetComponent<EnemyScript>().AddToCount();

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
        transform.position += speed * Time.deltaTime * direction;
    }

    private void OnDestroy()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().AddToScore(200);
    }
    public void SpawnChilds()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            Debug.Log("Added");
            var obj = Instantiate(child);

            obj.transform.position = gameObject.transform.position;
            obj.transform.up = transform.up;

        }
    }
}

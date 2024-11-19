using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int controllerHealth = 100;
    [SerializeField] private int controllerMaxHealth = 100;
    [SerializeField] private AudioSource pickupSfx;
    [SerializeField] private AudioSource damageSfx;
    [SerializeField] private ChaseAi chaseAI;
    public bool isSpawner = false;
    [SerializeField] private DamageEffect playerDamageUi;
    public bool isDead;
    private void Start()
    {
        controllerHealth = controllerMaxHealth;
    }
    void Update()
    {
        if (CheckIfDead() == false)
        {
            Die();
        }
    }
    public void Heal(int healAmount)
    {
        if ((controllerHealth + healAmount) > controllerMaxHealth)
        {
            controllerHealth = controllerMaxHealth;
        }
        else
        {
            controllerHealth += healAmount;
        }
        if (gameObject.name == "Player")
        {
            pickupSfx.Play();
        }
    }
    public void TakeDamage(int damage)
    {
        controllerHealth -= damage;
        if (gameObject.name == "Player")
        {
            playerDamageUi.StartEffect();
        }
        else
        {
            damageSfx.Play();
        }
    }
    public bool CheckIfDead()
    {
        if (controllerHealth < 0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    void Die()
    {
        isDead = true;
        if (gameObject.name != "Player")
        {
            GameObject manager = GameObject.Find("EnemyController");
            manager.GetComponent<EnemyScript>().RemoveToCount();
        }
        if (isSpawner)
        {
            gameObject.GetComponent<StraightAi>().SpawnChilds();
        }
        if (chaseAI != null)
        {
            chaseAI.SpawnPickup();
        }
        DestroyImmediate(gameObject);
    }
}

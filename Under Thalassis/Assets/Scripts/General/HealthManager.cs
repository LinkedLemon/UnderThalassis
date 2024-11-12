using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int ControllerHealth = 100;
    [SerializeField] private int ControllerMaxHealth = 100;
    [SerializeField] private AudioSource PickupSfx;
    [SerializeField] private AudioSource damageSfx;
    [SerializeField] private ChaseAi chaseAI;
    public bool isSpawner = false;
    [SerializeField] private DamageEffect PlayerDamageUi;
    public bool isDead;
    private void Start()
    {
        ControllerHealth = ControllerMaxHealth;
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
        if ((ControllerHealth + healAmount) > ControllerMaxHealth)
        {
            ControllerHealth = ControllerMaxHealth;
        }
        else
        {
            ControllerHealth += healAmount;
        }
        if (gameObject.name == "Player")
        {
            PickupSfx.Play();
        }
    }
    public void TakeDamage(int damage)
    {
        ControllerHealth -= damage;
        if (gameObject.name == "Player")
        {
            PlayerDamageUi.StartEffect();
        }
        else
        {
            damageSfx.Play();
        }
    }
    public bool CheckIfDead()
    {
        if (ControllerHealth < 0)
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

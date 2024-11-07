using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private int ControllerHealth = 100;
    [SerializeField] private int ControllerMaxHealth = 100;

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
    }
    public void TakeDamage(int damage)
    {
        ControllerHealth -= damage;
    }
    bool CheckIfDead()
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
        Destroy(gameObject, 10f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageArea : MonoBehaviour
{
    [SerializeField] private int DamageFieldAmount = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            HealthManager Player = collision.gameObject.GetComponent<HealthManager>();
            Player.TakeDamage(DamageFieldAmount);
        }
    }
}

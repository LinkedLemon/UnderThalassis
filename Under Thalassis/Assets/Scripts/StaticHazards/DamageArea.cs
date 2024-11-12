using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DamageArea : MonoBehaviour
{
    [SerializeField] private int DamageFieldAmount = 1;
    private int timer = 200;
    private EnemyScript EnemyManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (timer == 200)
        {
            if (collision.gameObject.name == "Player" && collision.gameObject.layer == 3)
            {
                collision.gameObject.GetComponent<HealthManager>().TakeDamage(DamageFieldAmount); ;
            }
            Timeout();
        }
    }

    private void Timeout()
    {
        while (timer > 0)
        {
            timer--;

            if (timer <= 0)
            {
                timer = 200;
                break;
            }
        }
    }
}



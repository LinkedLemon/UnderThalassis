using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    [SerializeField] private int DamageAmount = 10;
    [SerializeField] private BoxCollider2D _collider;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hitsomething");
        collision.GetComponent<HealthManager>().TakeDamage(DamageAmount);
    }

    private void Start()
    {
        _collider.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            MeleeAttack();
        }
    }

    private void MeleeAttack()
    {
        Debug.Log("Attack");
        _collider.enabled = true;
        //yield return new WaitForSeconds(4);
        //collider.enabled = false;
    }
}

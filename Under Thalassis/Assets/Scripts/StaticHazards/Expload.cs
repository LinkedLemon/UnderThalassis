using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expload : MonoBehaviour
{
    [SerializeField] private CircleCollider2D exploadCollider;
    [SerializeField] private CircleCollider2D hitboxCollider;

    private void Start()
    {
        exploadCollider.enabled = false;
        hitboxCollider.enabled = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        exploadCollider.enabled=true;
        Destroy(gameObject, 2f);
    }
}


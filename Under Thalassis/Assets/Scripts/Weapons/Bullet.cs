using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{

    [SerializeField] private float bulletSpeed = 1.0f;

    private bool hitSomething = true;
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        if (hitSomething == true)
        {
            transform.Translate(transform.up * bulletSpeed * Time.deltaTime, Space.World);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hitSomething = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speargun : MonoBehaviour
{
    [SerializeField] private GameObject BulletPrefab;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(BulletPrefab, transform.position, transform.rotation);
    }
}

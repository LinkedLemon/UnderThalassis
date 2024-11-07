using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Speargun : MonoBehaviour
{
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private TextMeshProUGUI AmmoUI;
    [SerializeField] private int AmmoCount = 5;
    [SerializeField] private int MaxAmmoCount = 5;

    private void Update()
    {
        // keep ammo total displayed on ui
        AmmoUI.text = AmmoCount.ToString();

        if (Input.GetButtonDown("Fire1") && AmmoCount > 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        AmmoCount--;
        Instantiate(BulletPrefab, transform.position, transform.rotation);
    }

    public void Reload(int reloadAmmount)
    {
        if ((AmmoCount + reloadAmmount) > MaxAmmoCount)
        {
            AmmoCount = MaxAmmoCount;
        }
        else
        {
            AmmoCount += reloadAmmount;
        }
    }
}

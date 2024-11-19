using TMPro;
using UnityEngine;

public class Speargun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private AudioSource shootSfx;
    [SerializeField] private AudioSource ammoPickupSfx;
    [SerializeField] private TextMeshProUGUI ammoUI;
    [SerializeField] private int ammoCount = 5;
    [SerializeField] private int maxAmmoCount = 10;

    private void Update()
    {
        // keep ammo total displayed on ui
        ammoUI.text = ammoCount.ToString();

        if (Input.GetButtonDown("Fire1") && ammoCount > 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        ammoCount--;
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        shootSfx.Play();
    }

    public void Reload(int reloadAmmount)
    {
        if ((ammoCount + reloadAmmount) > maxAmmoCount)
        {
            ammoCount = maxAmmoCount;
        }
        else
        {
            ammoCount += reloadAmmount;
        }
        ammoPickupSfx.Play();
    }
}

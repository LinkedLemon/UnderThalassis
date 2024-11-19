using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] private int ammoAmount = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.TryGetComponent<PlayerController>(out PlayerController Player))
        {
            Player.GetComponentInChildren<Speargun>().Reload(ammoAmount);
            Destroy(gameObject);
        }
    }
}

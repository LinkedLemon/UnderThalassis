using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int healAmount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            collision.gameObject.GetComponent<HealthManager>().Heal(healAmount);
            Destroy(gameObject);
        }
    }
}

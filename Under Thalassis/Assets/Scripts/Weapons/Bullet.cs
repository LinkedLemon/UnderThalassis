using UnityEngine;

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
            transform.Translate(bulletSpeed * Time.deltaTime * transform.up, Space.World);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            hitSomething = true;
        }
        else if (collision.gameObject.layer == 6)
        {
            GetComponent<CapsuleCollider2D>().enabled = false;
            hitSomething = false;
            collision.gameObject.GetComponent<HealthManager>().TakeDamage(30);
        }
        else if (collision.gameObject.layer == 8)
        {
            return;
        }
        else
        {
            hitSomething = false;
        }
    }
}

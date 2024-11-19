using UnityEngine;

public class DamageEffect : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private HealthManager health;
    public void StartEffect()
    {
        animator.Play("DamagePlayer");
    }
}

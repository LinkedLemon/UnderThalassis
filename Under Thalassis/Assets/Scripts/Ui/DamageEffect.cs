using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEffect : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private HealthManager Health;
    public void StartEffect()
    {
        animator.Play("DamagePlayer");
    }
}

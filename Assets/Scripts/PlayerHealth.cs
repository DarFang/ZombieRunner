using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health = 100f;

    public void TakeDamage(float dmg)
    {
        health -= dmg;;
        if(health < 0)
        {
            Die();
        }
    }
    public void Die()
    {
        GetComponent<DeathHandler>().HandleDeath();
        Debug.Log("You have unfortunately died");
    }
}

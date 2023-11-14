using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public HealthBar healthBar;

    public virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int healingAmount)
    {
        currentHealth += healingAmount;
        currentHealth = Mathf.Min(currentHealth, maxHealth);
        healthBar.SetHealth(currentHealth);
    }

    protected virtual void Die()
    {
        // Karakter öldüğünde yapılacak işlemler
    }

    public void UpdateHealthBar()
    {
        // Sağlık barını güncelle
        healthBar.SetHealth(currentHealth);
    }
}
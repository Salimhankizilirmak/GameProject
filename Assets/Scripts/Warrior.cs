<<<<<<< HEAD
using UnityEngine;

public class Warrior : Character
{

    void Start()
    {
        // Warrior'ın başlangıç sağlık değerlerini ayarla
        maxHealth = 100;
        currentHealth = maxHealth;
        healthBar.SetHealth(maxHealth);
    }


=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour   //Character
{
    public int maxHealth = 100;
    public int currentHealth;
    public int strength = 10;

    public HealthBar healthBar;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
        if (currentHealth <= 0)
        {
            // Implement game over logic or character death here
            Die();
        }
    }

    private void Die()
    {
        animator.SetTrigger("Die");
    }

    public void Attack(Enemy enemy)
    {
        int damage = strength; // You can add more complex calculations
        enemy.TakeDamage(damage);
    }
>>>>>>> 8fa05a96e1c9a7c347317930b8d92fead6ddf7a5
}

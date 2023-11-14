<<<<<<< HEAD
=======
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
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour   //Character
{
    public int maxHealth = 100;
    public int currentHealth;
    public int strength = 10;

    public HealthBar healthBar;
<<<<<<< HEAD

    public bool isDead = false;
=======
    public Animator animator;
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0

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
<<<<<<< HEAD
        // Implement character death logic here

        isDead = true;
=======
        animator.SetTrigger("Die");
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0
    }

    public void Attack(Enemy enemy)
    {
        int damage = strength; // You can add more complex calculations
        enemy.TakeDamage(damage);
    }
<<<<<<< HEAD
=======
>>>>>>> 8fa05a96e1c9a7c347317930b8d92fead6ddf7a5
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0
}

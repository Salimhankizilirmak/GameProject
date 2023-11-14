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


}

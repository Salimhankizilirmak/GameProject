using UnityEngine;

public class Elena : Character
{

    void Start()
    {
        // Elena'nın başlangıç sağlık değerlerini ayarla
        maxHealth = 100;
        currentHealth = maxHealth;
        healthBar.SetHealth(maxHealth);
    }

    void Update()
    {
        healthBar.SetHealth(currentHealth);
        
    }

}

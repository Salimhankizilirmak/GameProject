using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
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
=======
public class Character : MonoBehaviour  
{
    public int maxHealth = 100;
    public int currentHealth;
    public int strength = 10;
    //public int damage = 5;

    public Item currentItem; // The currently equipped item

    public CharacterInventory inventory = new CharacterInventory();

    // Example method to add an item to the character's inventory
    public void AddItemToInventory(Item item)
    {
        inventory.AddItem(item);
    }

    // Example method to remove an item from the character's inventory
    public void RemoveItemFromInventory(Item item)
    {
        inventory.RemoveItem(item);
    }

    
    // Start is called before the first frame update
    private void Start()
    {
        currentHealth = maxHealth;

        /*
        // Instantiate a weapon item
        WeaponItem weapon = new WeaponItem();
        weapon.name = "Sword";  //itemName
        weapon.damage = 10;
        weapon.itemIcon = Resources.Load<Sprite>("sword_icon"); // Load the icon from resources
        */

        // Load the weapon's icon sprite from the "Resources" folder
        Sprite weaponIcon = Resources.Load<Sprite>("sword_icon"); 

        // Instantiate a weapon item with the required arguments
        WeaponItem weapon = new WeaponItem("Sword", weaponIcon, 10);

        // Equip the weapon
        currentItem = weapon;

        // Use the current item
        currentItem.Use();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            // Implement game over logic or character death here
>>>>>>> 8fa05a96e1c9a7c347317930b8d92fead6ddf7a5
            Die();
        }
    }

<<<<<<< HEAD
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
=======
    private void Die()
    {
        // Implement character death logic here
    }

    public void Attack(Enemy enemy)
    {
        int damage = strength; // You can add more complex calculations
        enemy.TakeDamage(damage);
>>>>>>> 8fa05a96e1c9a7c347317930b8d92fead6ddf7a5
    }
}
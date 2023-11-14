using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour 
{
    // Add properties common to all items here  // a base class for items (weapons, potions, etc.):
 
    public string itemName;
    public Sprite itemIcon; // The icon or image representing the item
    public ItemType itemType; // An enum or string that specifies the item type
    
    // Constructor (optional, but can be useful)
    public Item(string name, Sprite icon, ItemType type)
    {
        itemName = name;
        itemIcon = icon;
        itemType = type;
    }

    // Method to use the item (e.g., drinking a potion or equipping armor)
    public virtual void UseItem()
    {
        // Implement item usage logic in derived item classes
    }

    public virtual void Use()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public enum ItemType
    {
        Weapon,
        Armor,
        Potion,
        // Add other item types as needed
    }

    public Sprite GetIcon()
    {
        return itemIcon;
    }

}

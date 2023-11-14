using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item1 : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public ItemType itemType;
    public string itemDescription;

    
    // Constructor (optional, but can be useful)
    public Item1(string name, Sprite icon, ItemType type)
    {
        itemName = name;
        itemIcon = icon;
        itemType = type;
    }

    public Item1(string name, string description)
    {
        itemName = name;
        itemDescription = description;
    }

     public Item1(string name, Sprite icon)
    {
        itemName = name;
        itemIcon = icon;
    }

    public Item1()
    {
       this.itemName = itemName;
       this.itemIcon = itemIcon;
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

    public virtual Sprite GetIcon()
    {
        return itemIcon;
    }
}

public enum ItemType
{
    Weapon,
    Armor,
    Potion,
    // Add other item types as needed
}

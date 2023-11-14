using UnityEngine;

public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public ItemType itemType;

    public Item(string name, Sprite icon, ItemType type)
    {
        itemName = name;
        itemIcon = icon;
        itemType = type;
    }
    
    public enum ItemType
    {
        Weapon,
        Potion,
        // Diğer türleri ekleyebilirsiniz
    }

    public virtual void UseItem(Character character)
    {
    }
}


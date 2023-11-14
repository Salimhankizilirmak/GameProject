using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponItem : Item
{
    public int damage;
    public int strength;
    
    public WeaponItem(string name, Sprite icon, int damage) : base(name, icon, ItemType.Weapon)
    {
        this.damage = damage;
    }

    public override void UseItem()
    {
        // Implement the logic for using the weapon (e.g., equipping it)
        // Implement weapon-specific usage logic here
        // For example, you can equip the weapon or use it in combat
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



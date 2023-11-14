using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : Item          //MonoBehaviour  //WeaponItem  //?
{
    public int damage = 20;
    //public float attackRate = 1f; // Attacks per second
    //private float nextAttackTime = 0f;

    public int strength = 50;

    //public string itemName = "Sword";
    //public Sprite itemIcon; 
    //public ItemType itemType;

    public string name = "Sword";
    public Sprite icon; 

/*   
    public Weapon1(string name, Sprite iconx)
    {
        itemName = name;
        itemIcon = iconx;
    }
*/
    
    public Weapon1()
    {
       this.itemName = name;
       this.itemIcon = icon;
    }
    

/*
    public Weapon1()
    {
        this.itemName = itemName;
        this.itemIcon = itemIcon;
    }
*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Attack(Character target)
    {
        /*
        if (Time.time >= nextAttackTime)
        {
            target.TakeDamage(damage);
            nextAttackTime = Time.time + 1f / attackRate;
        }
        */
    }

/*
    public Sprite GetIcon()
    {
        return base.GetIcon(); // Use the base class's implementation
    }
*/

    public override Sprite GetIcon()
    {
        return itemIcon;
    }
}


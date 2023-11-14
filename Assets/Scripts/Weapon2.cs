using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : Item     //MonoBehaviour  //WeaponItem  //?
{
    public int damage = 20;
    public int strength = 50;


    public string name = "Tridenttt";
    public Sprite icon; 


    public Weapon2()
    {
       this.itemName = name;
       this.itemIcon = icon;
    }

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

    public override Sprite GetIcon()
    {
        return itemIcon;
    }
}

    
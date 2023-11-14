using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion1 : Item   //PotionItem //MonoBehaviour
{
    // give some empowerments
    //...

    //public string itemName = "Potion1";   // Repulse 
    //public Sprite itemIcon; 

    public string name = "Potion1";   // Repulse 
    public Sprite icon; 


    public Potion1()
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
}

<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
=======
using System.Collections.Generic;
using System.Collections;
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
<<<<<<< HEAD

    public GameObject inventorySlotPrefab;
    public Transform inventoryPanel;  // Reference to the inventory panel
    //public Transform inventoryPanel1;
    

    // Reference the scriptable object for the item you want to add
    public Item1 weapon1;
    public Item1 weapon2;

    public Item1 potion1;


    //private CharacterInventory characterInventory; // Replace with your actual inventory class
    private List<Item1> characterInventory = new List<Item1>();


    // Function to add an item to the character's inventory
    public void AddItem(Item1 item)
    {
        characterInventory.Add(item);
        UpdateInventoryUI();
    }

    // Function to remove an item from the character's inventory
    public void RemoveItem(Item1 item)
    {
        characterInventory.Remove(item);
        UpdateInventoryUI();
    }


    // Function to update the inventory UI
    private void UpdateInventoryUI()
    {
        // Clear the existing inventory UI
        foreach (Transform child in inventoryPanel)
=======
    public GameObject inventorySlotPrefab;
    public Transform inventoryPanel_Elena;
    public Transform inventoryPanel_Warrior;

    public Elena elenaCharacter;
    public Warrior warriorCharacter;

    private Dictionary<string, List<Item>> characterInventories = new Dictionary<string, List<Item>>();

    private bool isUpdatingHealth = false;

     void Start()
    {
        // Envantarı güncelleyin
        UpdateInventoryUI();
        // Karakterlerin canını güncelle
        StartCoroutine(UpdateCharacterHealthCoroutine());
        //InvokeRepeating("UpdateCharacterHealth", 1.0f, 1.0f); // Her 2 saniyede bir can güncelle
    }

    private IEnumerator UpdateCharacterHealthCoroutine()
    {
        isUpdatingHealth = true;

        foreach (var characterInventory in characterInventories.Values)
        {
            foreach (Item item in characterInventory)
            {
                if (item.itemType == Item.ItemType.Weapon)
                {
                    Weapon weapon = item as Weapon;
                    weapon.UseItem(characterInventory == characterInventories["Elena"] ? elenaCharacter : warriorCharacter);
                }
                else if (item.itemType == Item.ItemType.Potion)
                {
                    Potion potion = item as Potion;
                    potion.UseItem(characterInventory == characterInventories["Elena"] ? elenaCharacter : warriorCharacter);
                }
                // Her öğenin işlenmesi arasında 1 saniye bekle
                yield return new WaitForSeconds(1.0f);
            }
            // Karakterin sağlığını güncelle
           UpdateCharacterHealth(characterInventory == characterInventories["Elena"] ? elenaCharacter : warriorCharacter, characterInventory);
           UpdateCharacterHealth(elenaCharacter, characterInventories["Elena"]);
           UpdateCharacterHealth(warriorCharacter, characterInventories["Warrior"]);
    
            }

        isUpdatingHealth = false;
    }

    private void AddItemToInventory(string characterName, Item item)
    {
        if (!characterInventories.ContainsKey(characterName))
        {
            characterInventories[characterName] = new List<Item>();
        }

        characterInventories[characterName].Add(item);
    }


    private void UpdateCharacterHealth(Character character, List<Item> inventory)
    {
        foreach (Item item in inventory)
        {
            if (item.itemType == Item.ItemType.Weapon)
            {
                Weapon weapon = item as Weapon;
                weapon.UseItem(character);
            }
            else if (item.itemType == Item.ItemType.Potion)
            {
                Potion potion = item as Potion;
                potion.UseItem(character);
            }
        }

         //update health bar
        character.healthBar.SetHealth(character.currentHealth);
    }

    private void UpdateInventoryUI()
    {
        // Icon ekle
        Sprite swordIcon = Resources.Load<Sprite>("sword_icon");
        Weapon swordW = new Weapon("Sword", 20, 30, swordIcon);

        Sprite axeIcon = Resources.Load<Sprite>("iron_axe");
        Weapon axe = new Weapon("Axe", 30, 30, axeIcon);

        Sprite staffIcon = Resources.Load<Sprite>("staff");
        Weapon staff = new Weapon("Staff", 40, 40, staffIcon);

        Sprite scytheIcon = Resources.Load<Sprite>("scythe");
        Weapon scythe = new Weapon("Scythe", 50, 40, scytheIcon);

        Sprite tridentIcon = Resources.Load<Sprite>("trident");
        Weapon trident = new Weapon("Trident", 60, 50, tridentIcon);

        Sprite healthPotionIcon = Resources.Load<Sprite>("pot7");
        Potion healthPotion = new Potion("Health Potion", 10, healthPotionIcon);

        Sprite healthPotion2Icon = Resources.Load<Sprite>("potx2");
        Potion healthPotion2 = new Potion("Health Potion2", 20, healthPotion2Icon);

        Sprite healthPotion3Icon = Resources.Load<Sprite>("pot4");
        Potion healthPotion3 = new Potion("Health Potion3", 30, healthPotion3Icon);

        Sprite healthPotion4Icon = Resources.Load<Sprite>("pot3");
        Potion healthPotion4 = new Potion("Health Potion4", 40, healthPotion4Icon);   

        Sprite healthPotion5Icon = Resources.Load<Sprite>("pot6");
        Potion healthPotion5 = new Potion("Health Potion5", 50, healthPotion5Icon);


        AddItemToInventory("Elena", swordW);
        AddItemToInventory("Elena", healthPotion);
        AddItemToInventory("Elena", trident);
        AddItemToInventory("Elena", healthPotion3);
        AddItemToInventory("Elena", staff);

        AddItemToInventory("Warrior", axe);
        AddItemToInventory("Warrior", healthPotion2);
        AddItemToInventory("Warrior", scythe);
        AddItemToInventory("Warrior", healthPotion4);
        AddItemToInventory("Warrior", swordW);

         // Elena'nın envanterini güncelle
        UpdatePanel(characterInventories["Elena"], inventoryPanel_Elena);

        // Warrior'ın envanterini güncelle
        UpdatePanel(characterInventories["Warrior"], inventoryPanel_Warrior);
    }

    private void UpdatePanel(List<Item> characterInventory, Transform panel)
    {
        foreach (Transform child in panel)
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0
        {
            Destroy(child.gameObject);
        }

<<<<<<< HEAD
        // Populate the UI with the current items in the inventory
        foreach (Item1 item in characterInventory)
        {
            Debug.Log("Item name: " + item.itemName);

            GameObject slot = Instantiate(inventorySlotPrefab, inventoryPanel);

            Image itemIcon = slot.GetComponent<Image>();

            itemIcon.sprite = item.itemIcon;

            //item.UseItem();
/*
            if (item is Weapon1)
            {
                Debug.Log("WEAPON1");

                //Weapon1 weapon1 = slot.AddComponent<Weapon1>();

                itemIcon.sprite = weapon1.itemIcon;

            }
            else if (item is Weapon2)
            {
                Debug.Log("WEAPON2");

                //Weapon1 weapon1 = slot.AddComponent<Weapon1>();

                itemIcon.sprite = weapon1.itemIcon;

            }
            else if (item is Potion1)
            {
                Debug.Log("POTION1");

                //Potion1 potion1 = item as Potion1;
             
                //Potion1 potion1 = slot.AddComponent<Potion1>();

                itemIcon.sprite = potion1.itemIcon;
            }
*/

        }

    }


    // Start is called before the first frame update
    void Start()
    {
        characterInventory.Add(weapon1);
        characterInventory.Add(weapon2);
        characterInventory.Add(potion1);
        
        Debug.Log("Items added");

        Debug.Log("characterInventory count: " + characterInventory.Count);

        UpdateInventoryUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }






    /*
    public GameObject inventorySlotPrefab;
    public Transform inventoryPanel;  // Reference to the inventory panel

    public Transform inventoryPanel1;

    // Reference the scriptable object for the item you want to add
    public Item1 weapon2;

    //private CharacterInventory characterInventory; // Replace with your actual inventory class
    private List<Item> characterInventory = new List<Item>();

    private List<Item1> characterInventory1 = new List<Item1>();


    // Function to add an item to the character's inventory
    public void AddItem(Item item)
    {
        characterInventory.Add(item);
        UpdateInventoryUI();
    }

    // Function to add an item to the character's inventory
    public void AddItem(Item1 item1)
    {
        characterInventory1.Add(item1);
        UpdateInventoryUI();
    }

    // Function to remove an item from the character's inventory
    public void RemoveItem(Item item)
    {
        characterInventory.Remove(item);
        UpdateInventoryUI();
    }

    // Function to update the inventory UI
    private void UpdateInventoryUI()
    {
        // Clear the existing inventory UI
        foreach (Transform child in inventoryPanel)
        {
            Destroy(child.gameObject);
        }

        // Populate the UI with the current items in the inventory
        foreach (Item item in characterInventory)
        {
            Debug.Log("Item name: " + item.itemName);

            GameObject slot = Instantiate(inventorySlotPrefab, inventoryPanel);
            //Image itemIcon = slot.GetComponentInChildren<Image>();
            Image itemIcon = slot.GetComponent<Image>();
            //SpriteRenderer itemIcon = slot.GetComponent<SpriteRenderer>();
            //itemIcon.sprite = item.GetIcon();
            //itemIcon.sprite = item.itemIcon;
            // Add code to display additional information if needed

            //slot.AddComponent(Item Weapon1)

            //itemIcon.sprite = item.itemIcon;


            if (item is Weapon1)
            {
                Debug.Log("WEAPON1");

                //Weapon1 weapon1 = item as Weapon1;
                // Configure Weapon1 properties
                // For example, weapon1.damage = 20;

                //Weapon1 weapon = slot.AddComponent(Item Weapon1);
                Weapon1 weapon1 = slot.AddComponent<Weapon1>();

                itemIcon.sprite = weapon1.itemIcon;

            }
            else if (item is Weapon2)
            {
                //Weapon2 weapon2 = item as Weapon2;
                // Configure Weapon2 properties
                // For example, weapon2.attackSpeed = 2.0f;


            }
            else if (item is Potion1)
            {
                Debug.Log("POTION1");

                //Potion1 potion1 = item as Potion1;
             
                Potion1 potion1 = slot.AddComponent<Potion1>();

                itemIcon.sprite = potion1.itemIcon;
            }

        }

        // Populate the UI with the current items in the inventory1
        foreach (Item1 item1 in characterInventory1)
        {
            Debug.Log("Item1 name: " + item1.itemName);

            GameObject slot = Instantiate(inventorySlotPrefab, inventoryPanel1);

            Image itemIcon = slot.GetComponent<Image>();

            itemIcon.sprite = item1.itemIcon;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        // Create some item objects
        Item item1 = new Item("Item 1", "Description 1");
        Item item2 = new Item("Item 2", "Description 2");
        Item item3 = new Item("Item 3", "Description 3");


        // Add the items to the inventory list
        characterInventory.Add(item1);
        characterInventory.Add(item2);
        characterInventory.Add(item3);

        //characterInventory.Add(Weapon1);   //'Weapon1' is a type, which is not valid in the given context
        // Assuming Weapon1 is a class representing an item
        //Sprite weapon1Icon = // Your sprite reference here
        // Create a Weapon1 instance with a name and icon
        //Weapon1 weapon1 = new Weapon1("Sword", weapon1Icon);
        Weapon1 weapon1 = new Weapon1();
        //Sprite icon = weapon1.itemIcon;
        //Debug.Log("Weapon1 icon: " + weapon1.itemIcon);
        characterInventory.Add(weapon1);


        //characterInventory.Add(Potion1);
        // Assuming Weapon1 is a class representing an item
        Potion1 potion1 = new Potion1();
        characterInventory.Add(potion1);


        // Reference the scriptable object for the item you want to add
        //private Item1 weapon2;
        characterInventory1.Add(weapon2);

        Debug.Log("Items added");

        Debug.Log("characterInventory count: " + characterInventory.Count);

        UpdateInventoryUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    */
}
=======
        foreach (Item item in characterInventory)
        {
            GameObject slot = Instantiate(inventorySlotPrefab, panel);
            Image itemIcon = slot.GetComponent<Image>();

            if (item != null)
            {
                itemIcon.sprite = item.itemIcon;
            }
        }
    }

}


   
    //private List<Item> characterInventory = new List<Item>();

/*
    void Start()
    {
        //icon ekle
        Sprite swordIcon = Resources.Load<Sprite>("swordIcon");
        Weapon sword = new Weapon("Sword", 20, 30, swordIcon);
        characterInventory.Add(sword);

        Sprite axeIcon = Resources.Load<Sprite>("axeIcon");
        Weapon axe = new Weapon("Axe", 30, 30, axeIcon);
        characterInventory.Add(axe);

        // Envantarı güncelleyin
        UpdateInventoryUI();
}
*/

/*
    private void UpdateInventoryUI()
    {
        foreach (Transform child in inventoryPanel)
        {
            Destroy(child.gameObject);
        }

        foreach (Item item in characterInventory)
        {
            GameObject slot = Instantiate(inventorySlotPrefab, inventoryPanel);
            Image itemIcon = slot.GetComponent<Image>();

            if (item != null)
            {
                itemIcon.sprite = item.itemIcon;
            }
        }
    }

    public void StartBattle()
    {
        foreach (Item item in characterInventory)
        {
            if (item.itemType == Item.ItemType.Weapon)
            {
                // Karakter silah taşıyorsa
                Weapon weapon = item as Weapon;
                if (elenaCharacter != null)
                {
                    elenaCharacter.TakeDamage(weapon.damage);
                }
                if (warriorCharacter != null)
                {
                    warriorCharacter.TakeDamage(weapon.damage);
                }
            }
            else if (item.itemType == Item.ItemType.Potion)
            {
                // Karakter iksir taşıyorsa
                Potion potion = item as Potion;
                if (elenaCharacter != null)
                {
                    elenaCharacter.Heal(potion.healingAmount);
                }
                if (warriorCharacter != null)
                {
                    warriorCharacter.Heal(potion.healingAmount);
                }
            }
        }
    }
    */
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0

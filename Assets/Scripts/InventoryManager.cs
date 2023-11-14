using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{

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
        {
            Destroy(child.gameObject);
        }

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

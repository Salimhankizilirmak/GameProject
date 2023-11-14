using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CombatManager : MonoBehaviour
{
    //public Character playerCharacter;
    //public Enemy enemy;

    //private bool playerTurn = true; // Player starts first

    //public Text endText;
    //public TextMeshProUGUI endText;

    public GameObject endText;
    private TextMeshProUGUI textMeshProComponent;  // Declare the TextMeshProUGUI variable

    public Elena elena;
    public Warrior warrior;

    private bool elenaTurn = true ;


    private float attackCooldown = 10.0f; // The time in seconds between attacks
    private float nextAttackTime = 0.0f; // The time when the next attack can occur

    // Start is called before the first frame update
    void Start()
    {
        // Access the TextMeshProUGUI component within the endText GameObject
        textMeshProComponent = endText.GetComponentInChildren<TextMeshProUGUI>();

        // Set the initial nextAttackTime to the current time
        nextAttackTime = Time.time + 10.0f;
    }
    
    // Update is called once per frame
    private void Update()
    {

    /*
        if (playerTurn)
        {
            /*
            // Player's turn
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerCharacter.Attack(enemy);
                playerTurn = false;
            }
            * /

            playerCharacter.Attack(enemy);
            playerTurn = false;

        }
        else
        {
            // Enemy's turn
            enemy.Attack(playerCharacter);
            playerTurn = true;
        }
        */

        /*
        if (elenaTurn)
        {
            Debug.Log("warrior got hurt");
            int damage = 20;//some business codes
            warrior.TakeDamage(damage);
            
            elenaTurn = false;
        }
        else
        {
            Debug.Log("elena got hurt");
            elena.TakeDamage(10);

            elenaTurn = true;
        }
    */


        if (Time.time >= nextAttackTime)
        {
            // Perform the player's attack action here
            Debug.Log("Player is attacking!");

            if (elenaTurn)
            {
                Debug.Log("warrior got hurt");
                int damage = 20;//some business codes
                warrior.TakeDamage(damage);
                
                elenaTurn = false;
            }
            else
            {
                Debug.Log("elena got hurt");
                elena.TakeDamage(10);

                elenaTurn = true;
            }

            // Update nextAttackTime for the next attack
            nextAttackTime = Time.time + attackCooldown;
        }

        if (elena.isDead)
        {
            textMeshProComponent.text = "You Lost";

            endText.SetActive(true);
        }
        else if (warrior.isDead)
        {
            textMeshProComponent.text = "You Win";

            endText.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
<<<<<<< HEAD
=======
    //public Character character;

    //public Gradient gradient;
	//public Image fill;
>>>>>>> 8fa05a96e1c9a7c347317930b8d92fead6ddf7a5

    public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;
<<<<<<< HEAD
=======

		//fill.color = gradient.Evaluate(1f);
>>>>>>> 8fa05a96e1c9a7c347317930b8d92fead6ddf7a5
	}

    public void SetHealth(int health)
	{
		slider.value = health;
<<<<<<< HEAD
	}

=======

		//fill.color = gradient.Evaluate(slider.normalizedValue);
	}

    // Start is called before the first frame update
    void Start()
    {
        //slider.maxValue = character.maxHealth;
        //slider.value = character.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
         //slider.value = character.currentHealth;
    }


>>>>>>> 8fa05a96e1c9a7c347317930b8d92fead6ddf7a5

    
}

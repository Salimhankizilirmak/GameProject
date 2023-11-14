using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0
    //public Character character;

    //public Gradient gradient;
	//public Image fill;
<<<<<<< HEAD
=======
>>>>>>> 8fa05a96e1c9a7c347317930b8d92fead6ddf7a5
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0

    public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;
<<<<<<< HEAD

		//fill.color = gradient.Evaluate(1f);
=======
<<<<<<< HEAD
=======

		//fill.color = gradient.Evaluate(1f);
>>>>>>> 8fa05a96e1c9a7c347317930b8d92fead6ddf7a5
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0
	}

    public void SetHealth(int health)
	{
		slider.value = health;
<<<<<<< HEAD
=======
<<<<<<< HEAD
	}

=======
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0

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
<<<<<<< HEAD
        //slider.value = character.currentHealth;
    }


=======
         //slider.value = character.currentHealth;
    }


>>>>>>> 8fa05a96e1c9a7c347317930b8d92fead6ddf7a5
>>>>>>> eedac35ae4cde0ba29a2ef6255ebf5fa8ca533b0

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterStats : MonoBehaviour
{
    public static characterStats characterstats;

    public GameObject Character;
    public float health;
    public float maxHealth;

    public GameObject Objectives;
    private int objectivesLeft;
    public Text totalObjectives;


// public GameObject Exit;


    public Text healthText;
    public GameObject healthBar;
    public Slider healthBarSlider;

    void Awake()
    {
        if (characterstats != null)
        {
            Destroy(characterstats);
        }
        else
        {
            characterstats = this;
        }

        DontDestroyOnLoad(this);
    }

    void Start()
    {
        ObjectDeliver.OnPop += handInObjective;
    }

    // Update is called once per frame
    void Update()
    {
       if (objectivesLeft == 0)
        {
            objectivesLeft = 3;
        }
           
    }


    public void DealDamage(float damage)
    {
        healthBar.SetActive(true);
        health -= damage;
        CheckDeath();
        setHealthUI();
    }
    public void HealCharacter()
    {
        health += health;
        CheckOverheal();
        setHealthUI();

    }
    public void CheckOverheal()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    public void CheckDeath()
    {
        if (health <= 0)
        {
            health = 0;
            Destroy(Character);
        }
    }
    float calcHealth()
    {
        return health / maxHealth;

    }
    private void setHealthUI()
    {
        healthBarSlider.value = calcHealth();
        healthText.text = Mathf.Ceil(health).ToString() + " / " + Mathf.Ceil(maxHealth).ToString();
    }


    public void handInObjective()
    {
        objectivesLeft = objectivesLeft - 1;
        totalObjectives.text = "Objectives Left: " + objectivesLeft.ToString();
    }

    private int CheckObjective()
    {
        return objectivesLeft;
    }

}

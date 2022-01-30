using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public GameObject playerStats;
    private int wepTier = 0;
    private int armorTier = 0;
    private int accTier = 0;
    public Image wepSlot, armSlot, accSlot;
    public Sprite wepSlot1, wepSlot2, wepSlot3;
    public Sprite armSlot1, armSlot2, armSlot3;
    public Sprite accSlot1, accSlot2, accSlot3;
    public Text display;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void giveWeapon()
    {
        if (wepTier == 0)
        {
            wepTier++;
            playerStats.GetComponent<Health>().damage += 3;
            wepSlot.sprite = wepSlot1;
            display.text = "Upgraded weapon!";
        }

        else if (wepTier == 1)
        {
            wepTier++;
            playerStats.GetComponent<Health>().damage += 3;
            wepSlot.sprite = wepSlot2;
            display.text = "Upgraded weapon!";
        }

        else if (wepTier == 2)
        {
            wepTier++;
            playerStats.GetComponent<Health>().damage += 3;
            wepSlot.sprite = wepSlot3;
            display.text = "Upgraded weapon!";
        }

        else
        {
            display.text = "Max weapon reached!";
        }
    }

    public void giveArmor()
    {
        if (armorTier == 0)
        {
            armorTier++;
            playerStats.GetComponent<Health>().armor += 1;
            armSlot.sprite = armSlot1;
            display.text = "Upgraded armor!";
        }

        else if (armorTier == 1)
        {
            armorTier++;
            playerStats.GetComponent<Health>().armor += 1;
            armSlot.sprite = armSlot2;
            display.text = "Upgraded armor!";
        }

        else if (armorTier == 2)
        {
            armorTier++;
            playerStats.GetComponent<Health>().armor += 1;
            armSlot.sprite = armSlot3;
            display.text = "Upgraded armor!";
        }

        else
        {
            display.text = "Max armor reached!";
        }
    }

    public void giveAccessory()
    {
        if (accTier == 0)
        {
            accTier++;
            playerStats.GetComponent<Health>().currentHealth += 6;
            playerStats.GetComponent<Health>().maxHealth += 6;
            accSlot.sprite = accSlot1;
            display.text = "Upgraded accessory!";
        }

        else if (accTier == 1)
        {
            accTier++;
            playerStats.GetComponent<Health>().currentHealth += 6;
            playerStats.GetComponent<Health>().maxHealth += 6;
            accSlot.sprite = accSlot2;
            display.text = "Upgraded accessory!";
        }

        else if (accTier == 2)
        {
            accTier++;
            playerStats.GetComponent<Health>().currentHealth += 6;
            playerStats.GetComponent<Health>().maxHealth += 6;
            accSlot.sprite = accSlot3;
            display.text = "Upgraded accessory!";
        }

        else
        {
            display.text = "Max accessory reached!";
        }
    }
}

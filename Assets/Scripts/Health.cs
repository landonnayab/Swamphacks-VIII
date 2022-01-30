using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int currentHealth = 20;
    public int maxHealth = 20;
    public int damage = 6;
    public int armor = 0;
    private Slider bar;
    public GameObject greenBar;

    // Start is called before the first frame update
    void Start()
    {
        bar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        bar.maxValue = maxHealth;
        bar.value = currentHealth;
        if (bar.value <= 0)
        {
            greenBar.SetActive(false);
        }
        else
        {
            greenBar.SetActive(true);
        }
    }
}

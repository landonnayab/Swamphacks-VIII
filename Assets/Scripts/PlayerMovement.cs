using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private int spacesToMove;
    public int side = 1;
    private int tile = 0;
    public Text rng;
    public GameObject rollButton;
    public GameObject rollDisplay;
    public GameObject combat;
    public GameObject playerHealth;
    public Image enemyCard;
    public Sprite tribe, cave, mountain, dark;
    public GameObject itemManagement;
    public GameObject textDisplay;
    public AudioSource start;
    public AudioSource idle;
    public AudioSource fightMusic;
    public AudioSource fightWon;

    void Start()
    {

    }

    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.position;

        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;

        yield return new WaitForSeconds(0.5f);

        if (tile != 6 && tile != 3 && tile != 0)
        {
            combat.SetActive(true);
            fightMusic.Play();
            start.Stop();
            fightWon.Stop();
            idle.Stop();
            if (side == 1)
            {
                enemyCard.sprite = tribe;
            }
            else if (side == 2)
            {
                enemyCard.sprite = cave;
            }
            else if (side == 3)
            {
                enemyCard.sprite = mountain;
            }
            if (side == 4)
            {
                enemyCard.sprite = dark;
            }
        }

        else if (tile == 6 || tile == 3)
        {
            int rollItem = Random.Range(1, 4);
            print(rollItem);
            textDisplay.SetActive(true);

            switch (rollItem)
            {
                case 1:
                    itemManagement.GetComponent<Items>().giveWeapon();
                    break;

                case 2:
                    itemManagement.GetComponent<Items>().giveArmor();
                    break;

                case 3:
                    itemManagement.GetComponent<Items>().giveAccessory();
                    break;
            }            
            
        }

        else if (tile == 0)
        {
            textDisplay.SetActive(true);
            textDisplay.GetComponent<Text>().text = "Rest area. Health restored!";
        }

        rollButton.SetActive(true);
        rollDisplay.SetActive(false);
    }

    public void buttonPushed()
    {
        rollButton.SetActive(false);
        rollDisplay.SetActive(true);
        textDisplay.SetActive(false);
        Vector3 positionToMoveTo = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        spacesToMove = Random.Range(1, 4);
        rng.text = spacesToMove.ToString();
        tile += spacesToMove;

        switch (side)
        {
            case 1:
                positionToMoveTo = new Vector3(transform.position.x - (8 * spacesToMove), transform.position.y, transform.position.z);
                if (positionToMoveTo.x <= -72)
                {
                    positionToMoveTo.x = -72;
                    side += 1;
                    tile = 0;
                    playerHealth.GetComponent<Health>().currentHealth = playerHealth.GetComponent<Health>().maxHealth;
                }
                break;

            case 2:
                positionToMoveTo = new Vector3(transform.position.x, transform.position.y, transform.position.z + (8 * spacesToMove));
                if (positionToMoveTo.z >= 72)
                {
                    positionToMoveTo.z = 72;
                    side += 1;
                    tile = 0;
                    playerHealth.GetComponent<Health>().currentHealth = playerHealth.GetComponent<Health>().maxHealth;
                }
                break;

            case 3:
                positionToMoveTo = new Vector3(transform.position.x + (8 * spacesToMove), transform.position.y, transform.position.z);
                if (positionToMoveTo.x >= 0)
                {
                    positionToMoveTo.x = 0;
                    side += 1;
                    tile = 0;
                    playerHealth.GetComponent<Health>().currentHealth = playerHealth.GetComponent<Health>().maxHealth;
                }
                break;

            case 4:
                positionToMoveTo = new Vector3(transform.position.x, transform.position.y, transform.position.z - (8 * spacesToMove));
                if (positionToMoveTo.z <= 0)
                {
                    positionToMoveTo.z = 0;
                    side = 1;
                    tile = 0;
                    playerHealth.GetComponent<Health>().currentHealth = playerHealth.GetComponent<Health>().maxHealth;
                }
                break;
        }

        StartCoroutine(LerpPosition(positionToMoveTo, (float)spacesToMove / 2));
    }
}

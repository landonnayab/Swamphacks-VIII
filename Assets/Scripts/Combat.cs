using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combat : MonoBehaviour
{
    public GameObject playerHealth;
    public GameObject enemyHealth;
    public GameObject hud;
    public GameObject deadScreen;
    private int slot = 1;
    public Image left1, left2, left3, left4, left5;
    public Image right1, right2, right3, right4, right5;
    public Image middle1, middle2, middle3, middle4, middle5;
    public Sprite lightAtk, heavyAtk, block, unknown;
    private int playerWins = 0;
    private int enemyWins = 0;
    private int[] playerAtks = new int[5];
    private int[] enemyAtks = new int[5];
    private int winner = 0;
    public AudioSource fightMusic;
    public AudioSource fightWon;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectAttack(string type)
    {
        switch (slot)
        {
            case 1:
                if (type.Equals("light"))
                {
                    left1.sprite = lightAtk;
                    playerAtks[0] = 1;
                }

                else if (type.Equals("heavy"))
                {
                    left1.sprite = heavyAtk;
                    playerAtks[0] = 2;
                }

                else if (type.Equals("block"))
                {
                    left1.sprite = block;
                    playerAtks[0] = 3;
                }

                slot++;
                break;

            case 2:
                if (type.Equals("light"))
                {
                    left2.sprite = lightAtk;
                    playerAtks[1] = 1;
                }

                else if (type.Equals("heavy"))
                {
                    left2.sprite = heavyAtk;
                    playerAtks[1] = 2;
                }

                else if (type.Equals("block"))
                {
                    left2.sprite = block;
                    playerAtks[1] = 3;
                }

                slot++;
                break;

            case 3:
                if (type.Equals("light"))
                {
                    left3.sprite = lightAtk;
                    playerAtks[2] = 1;
                }

                else if (type.Equals("heavy"))
                {
                    left3.sprite = heavyAtk;
                    playerAtks[2] = 2;
                }

                else if (type.Equals("block"))
                {
                    left3.sprite = block;
                    playerAtks[2] = 3;
                }

                slot++;
                break;

            case 4:
                if (type.Equals("light"))
                {
                    left4.sprite = lightAtk;
                    playerAtks[3] = 1;
                }

                else if (type.Equals("heavy"))
                {
                    left4.sprite = heavyAtk;
                    playerAtks[3] = 2;
                }

                else if (type.Equals("block"))
                {
                    left4.sprite = block;
                    playerAtks[3] = 3;
                }

                slot++;
                break;

            case 5:
                if (type.Equals("light"))
                {
                    left5.sprite = lightAtk;
                    playerAtks[4] = 1;
                }

                else if (type.Equals("heavy"))
                {
                    left5.sprite = heavyAtk;
                    playerAtks[4] = 2;
                }

                else if (type.Equals("block"))
                {
                    left5.sprite = block;
                    playerAtks[4] = 3;
                }

                //BEGIN COMBAT
                enemyAtks[0] = Random.Range(1, 4);
                if (playerAtks[0] != enemyAtks[0])
                {
                    if (playerAtks[0] == 1 && enemyAtks[0] == 2)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[0] == 1 && enemyAtks[0] == 3)
                    {
                        enemyWins++;
                    }
                    else if (playerAtks[0] == 2 && enemyAtks[0] == 1)
                    {
                        enemyWins++;
                    }
                    else if (playerAtks[0] == 2 && enemyAtks[0] == 3)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[0] == 3 && enemyAtks[0] == 1)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[0] == 3 && enemyAtks[0] == 2)
                    {
                        enemyWins++;
                    }
                }

                enemyAtks[1] = Random.Range(1, 4);
                if (playerAtks[1] != enemyAtks[1])
                {
                    if (playerAtks[1] == 1 && enemyAtks[1] == 2)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[1] == 1 && enemyAtks[1] == 3)
                    {
                        enemyWins++;
                    }
                    else if (playerAtks[1] == 2 && enemyAtks[1] == 1)
                    {
                        enemyWins++;
                    }
                    else if (playerAtks[1] == 2 && enemyAtks[1] == 3)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[1] == 3 && enemyAtks[1] == 1)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[1] == 3 && enemyAtks[1] == 2)
                    {
                        enemyWins++;
                    }
                }

                enemyAtks[2] = Random.Range(1, 4);
                if (playerAtks[2] != enemyAtks[2])
                {
                    if (playerAtks[2] == 1 && enemyAtks[2] == 2)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[2] == 1 && enemyAtks[2] == 3)
                    {
                        enemyWins++;
                    }
                    else if (playerAtks[2] == 2 && enemyAtks[2] == 1)
                    {
                        enemyWins++;
                    }
                    else if (playerAtks[2] == 2 && enemyAtks[2] == 3)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[2] == 3 && enemyAtks[2] == 1)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[2] == 3 && enemyAtks[2] == 2)
                    {
                        enemyWins++;
                    }
                }

                enemyAtks[3] = Random.Range(1, 4);
                if (playerAtks[3] != enemyAtks[3])
                {
                    if (playerAtks[3] == 1 && enemyAtks[3] == 2)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[3] == 1 && enemyAtks[3] == 3)
                    {
                        enemyWins++;
                    }
                    else if (playerAtks[3] == 2 && enemyAtks[3] == 1)
                    {
                        enemyWins++;
                    }
                    else if (playerAtks[3] == 2 && enemyAtks[3] == 3)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[3] == 3 && enemyAtks[3] == 1)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[3] == 3 && enemyAtks[3] == 2)
                    {
                        enemyWins++;
                    }
                }

                enemyAtks[4] = Random.Range(1, 4);
                if (playerAtks[4] != enemyAtks[4])
                {
                    if (playerAtks[4] == 1 && enemyAtks[4] == 2)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[4] == 1 && enemyAtks[4] == 3)
                    {
                        enemyWins++;
                    }
                    else if (playerAtks[4] == 2 && enemyAtks[4] == 1)
                    {
                        enemyWins++;
                    }
                    else if (playerAtks[4] == 2 && enemyAtks[4] == 3)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[4] == 3 && enemyAtks[4] == 1)
                    {
                        playerWins++;
                    }
                    else if (playerAtks[4] == 3 && enemyAtks[4] == 2)
                    {
                        enemyWins++;
                    }
                }

                if (playerWins > enemyWins)
                {
                    winner = 1;
                }
                else if (playerWins < enemyWins)
                {
                    winner = 2;
                }
                else
                {
                    winner = 0;
                }

                StartCoroutine(PlayAnimation(enemyAtks, playerAtks, winner));
                StartCoroutine(ClearIcons());

                //SET TO TERMINATE
                slot = 1;
                playerWins = 0;
                enemyWins = 0;
                playerAtks = new int[5];
                enemyAtks = new int[5];
                break;
        }
    }

    IEnumerator ClearIcons()
    {
        Color32 g = new Color32(102, 102, 102, 255);

        yield return new WaitForSeconds(3f);

        left1.sprite = null;
        left2.sprite = null;
        left3.sprite = null;
        left4.sprite = null;
        left5.sprite = null;

        right1.sprite = unknown;
        right2.sprite = unknown;
        right3.sprite = unknown;
        right4.sprite = unknown;
        right5.sprite = unknown;

        middle1.color = g;
        middle2.color = g;
        middle3.color = g;
        middle4.color = g;
        middle5.color = g;

        if (enemyHealth.GetComponent<Health>().currentHealth <= 0)
        {
            hud.SetActive(false);
            enemyHealth.GetComponent<Health>().currentHealth = enemyHealth.GetComponent<Health>().maxHealth;
            fightMusic.Stop();
            fightWon.Play();
        }
        else if (playerHealth.GetComponent<Health>().currentHealth <= 0)
        {
            deadScreen.SetActive(true);
        }
    }

    IEnumerator PlayAnimation(int[] enemyAtks, int[] playerAtks, int winner)
    {
        if (enemyAtks[0] == 1)
        {
            right1.sprite = lightAtk;
        }

        else if (enemyAtks[0] == 2)
        {
            right1.sprite = heavyAtk;
        }

        else if (enemyAtks[0] == 3)
        {
            right1.sprite = block;
        }

        if (playerAtks[0] != enemyAtks[0])
        {
            if (playerAtks[0] == 1 && enemyAtks[0] == 2)
            {
                middle1.color = Color.green;
            }
            else if (playerAtks[0] == 1 && enemyAtks[0] == 3)
            {
                middle1.color = Color.red;
            }
            else if (playerAtks[0] == 2 && enemyAtks[0] == 1)
            {
                middle1.color = Color.red;
            }
            else if (playerAtks[0] == 2 && enemyAtks[0] == 3)
            {
                middle1.color = Color.green;
            }
            else if (playerAtks[0] == 3 && enemyAtks[0] == 1)
            {
                middle1.color = Color.green;
            }
            else if (playerAtks[0] == 3 && enemyAtks[0] == 2)
            {
                middle1.color = Color.red;
            }
        }
        else
        {
            middle1.color = Color.yellow;
        }

        yield return new WaitForSeconds(0.5f);

        if (enemyAtks[1] == 1)
        {
            right2.sprite = lightAtk;
        }

        else if (enemyAtks[1] == 2)
        {
            right2.sprite = heavyAtk;
        }

        else if (enemyAtks[1] == 3)
        {
            right2.sprite = block;
        }

        if (playerAtks[1] != enemyAtks[1])
        {
            if (playerAtks[1] == 1 && enemyAtks[1] == 2)
            {
                middle2.color = Color.green;
            }
            else if (playerAtks[1] == 1 && enemyAtks[1] == 3)
            {
                middle2.color = Color.red;
            }
            else if (playerAtks[1] == 2 && enemyAtks[1] == 1)
            {
                middle2.color = Color.red;
            }
            else if (playerAtks[1] == 2 && enemyAtks[1] == 3)
            {
                middle2.color = Color.green;
            }
            else if (playerAtks[1] == 3 && enemyAtks[1] == 1)
            {
                middle2.color = Color.green;
            }
            else if (playerAtks[1] == 3 && enemyAtks[1] == 2)
            {
                middle2.color = Color.red;
            }
        }
        else
        {
            middle2.color = Color.yellow;
        }

        yield return new WaitForSeconds(0.5f);

        if (enemyAtks[2] == 1)
        {
            right3.sprite = lightAtk;
        }

        else if (enemyAtks[2] == 2)
        {
            right3.sprite = heavyAtk;
        }

        else if (enemyAtks[2] == 3)
        {
            right3.sprite = block;
        }

        if (playerAtks[2] != enemyAtks[2])
        {
            if (playerAtks[2] == 1 && enemyAtks[2] == 2)
            {
                middle3.color = Color.green;
            }
            else if (playerAtks[2] == 1 && enemyAtks[2] == 3)
            {
                middle3.color = Color.red;
            }
            else if (playerAtks[2] == 2 && enemyAtks[2] == 1)
            {
                middle3.color = Color.red;
            }
            else if (playerAtks[2] == 2 && enemyAtks[2] == 3)
            {
                middle3.color = Color.green;
            }
            else if (playerAtks[2] == 3 && enemyAtks[2] == 1)
            {
                middle3.color = Color.green;
            }
            else if (playerAtks[2] == 3 && enemyAtks[2] == 2)
            {
                middle3.color = Color.red;
            }
        }
        else
        {
            middle3.color = Color.yellow;
        }

        yield return new WaitForSeconds(0.5f);

        if (enemyAtks[3] == 1)
        {
            right4.sprite = lightAtk;
        }

        else if (enemyAtks[3] == 2)
        {
            right4.sprite = heavyAtk;
        }

        else if (enemyAtks[3] == 3)
        {
            right4.sprite = block;
        }

        if (playerAtks[3] != enemyAtks[3])
        {
            if (playerAtks[3] == 1 && enemyAtks[3] == 2)
            {
                middle4.color = Color.green;
            }
            else if (playerAtks[3] == 1 && enemyAtks[3] == 3)
            {
                middle4.color = Color.red;
            }
            else if (playerAtks[3] == 2 && enemyAtks[3] == 1)
            {
                middle4.color = Color.red;
            }
            else if (playerAtks[3] == 2 && enemyAtks[3] == 3)
            {
                middle4.color = Color.green;
            }
            else if (playerAtks[3] == 3 && enemyAtks[3] == 1)
            {
                middle4.color = Color.green;
            }
            else if (playerAtks[3] == 3 && enemyAtks[3] == 2)
            {
                middle4.color = Color.red;
            }
        }
        else
        {
            middle4.color = Color.yellow;
        }

        yield return new WaitForSeconds(0.5f);

        if (enemyAtks[4] == 1)
        {
            right5.sprite = lightAtk;
        }

        else if (enemyAtks[4] == 2)
        {
            right5.sprite = heavyAtk;
        }

        else if (enemyAtks[4] == 3)
        {
            right5.sprite = block;
        }

        if (playerAtks[4] != enemyAtks[4])
        {
            if (playerAtks[4] == 1 && enemyAtks[4] == 2)
            {
                middle5.color = Color.green;
            }
            else if (playerAtks[4] == 1 && enemyAtks[4] == 3)
            {
                middle5.color = Color.red;
            }
            else if (playerAtks[4] == 2 && enemyAtks[4] == 1)
            {
                middle5.color = Color.red;
            }
            else if (playerAtks[4] == 2 && enemyAtks[4] == 3)
            {
                middle5.color = Color.green;
            }
            else if (playerAtks[4] == 3 && enemyAtks[4] == 1)
            {
                middle5.color = Color.green;
            }
            else if (playerAtks[4] == 3 && enemyAtks[4] == 2)
            {
                middle5.color = Color.red;
            }
        }
        else
        {
            middle5.color = Color.yellow;
        }

        if (winner == 1)
        {
            enemyHealth.GetComponent<Health>().currentHealth = enemyHealth.GetComponent<Health>().currentHealth - playerHealth.GetComponent<Health>().damage + enemyHealth.GetComponent<Health>().armor;
        }
        else if (winner == 2)
        {
            playerHealth.GetComponent<Health>().currentHealth = playerHealth.GetComponent<Health>().currentHealth - enemyHealth.GetComponent<Health>().damage + playerHealth.GetComponent<Health>().armor;
        }

        yield return new WaitForSeconds(1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public static int lives = 3;

    public TMP_Text livesText;
    public TMP_Text scoreText;

    public GameObject winScreen;
    public GameObject loseScreen;

    public GameObject loseSound;
    public GameObject winSound;

    private void Update()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;

        if (lives <= 0)
        {
            loseScreen.SetActive(true);
            Instantiate(loseSound);
            enabled = false;
        }

        if (FindObjectsOfType<Brick>().Length < 1)
        {
            winScreen.SetActive(true);
            Instantiate(winSound);
            enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int score;
    public int level;
    public Text livesText;
    public Text scoreText;
    public Text levelText;
    public bool gameOver;
    public GameObject gameOverPanel;
    public int numberOfBricks;
    public GameObject victoryPanel;
    public GameObject ball;
    public PowerUpScript powerUp;
    public GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("MainMenu");
        lives = UIManager.lifeNumber;
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;
        levelText.text = "Level: " + level;
        numberOfBricks = GameObject.FindGameObjectsWithTag("Brick").Length;
        boss.GetComponent<BossScript>().StartMoving();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;

        if (lives <= 0)
        {
            lives = 0;
            GameOver();
        }

        livesText.text = "Lives: " + lives;
    }

    public void UsePowerUp(string powerUpName, int value)
    {
        switch (powerUpName)
        {
            case "Extra life":
                UpdateLives(value);
                break;
            case "Extra score":
                UpdateScore(powerUp.GetComponent<PowerUpScript>().buffValues[1]);
                break;
            case "Fire form":
                ball.GetComponent<SpriteRenderer>().sprite = ball.GetComponent<BallScript>().forms[1];
                break;
        }
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level-1");
    }

    public void ShowVictoryScreen()
    {
        gameOver = true;
        victoryPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void UpdateNumberOfBricks(int updateVlaue)
    {
        numberOfBricks += updateVlaue;
        if (numberOfBricks <= 0)
        {
            ShowVictoryScreen();
        }
    }
}
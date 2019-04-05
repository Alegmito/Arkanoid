using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject[] pauseObjects;
    public static int ballSpeed = 100;
    public Text ballSpeedText;
    public static int lifeNumber = 1;
    public Text lifeNumberText;

    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        if (GameObject.FindGameObjectsWithTag("OptionText").Length != 0)
        {
            ballSpeedText.text = ballSpeed.ToString();
            lifeNumberText.text = lifeNumber.ToString();
        }
        HidePaused();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                ShowPaused();
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                HidePaused();
            }
        }
    }

    //Reloads the level
    public void Reload()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void PauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            ShowPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            HidePaused();
        }
    }

        public void ShowPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    public void HidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene("Video1");
    }
    public void LoadSecondLevel()
    {
        SceneManager.LoadScene("Level-2");
    }

    public void LoadFinalBoss()
    {
        SceneManager.LoadScene("Video1-2");
    }

    public void LoadSecondVideo()
    {
        SceneManager.LoadScene("Video-2");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level-2");
    }

    public void loadBoss()
    {
        SceneManager.LoadScene("FinalBoss");
    }

    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void LeaderBoard()
    {
        SceneManager.LoadScene("LeaderBoard");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void ChangeBallSpeed()
    {
        if (ballSpeed < 500)
        {
            ballSpeed += 100;
            UpdateBallSpeed();
        }
        else
        {
            ballSpeed = 100;
            UpdateBallSpeed();
        }
    }

    private void UpdateBallSpeed()
    {
        ballSpeedText.text = ballSpeed.ToString();
    }

    public void ExitGame()
    {
        ExitGame();
    }

    public void ChangeLifeNumber()
    {
        if (lifeNumber < 3)
        {
            lifeNumber++;
        }
        else
        {
            lifeNumber = 1;    
        }
        UpdateLifeText();
    }

    private void UpdateLifeText()
    {
        lifeNumberText.text = lifeNumber.ToString();
    }
    //controls
}

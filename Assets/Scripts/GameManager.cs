using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject loseUI;
    public int points = 0;
    public TextMeshProUGUI scoreText;
    AudioSource audioSource;

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    private void ShowLoseUI()
    {
        loseUI.SetActive(true);
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("highscore", points);
        SceneManager.LoadScene("Menu");
    }
    public void OnGameOver()
    {
        ShowLoseUI();
        Time.timeScale = 0;
    }

    public void UpdateScore()
    {
        points++;
        scoreText.text = points.ToString();
    }
}

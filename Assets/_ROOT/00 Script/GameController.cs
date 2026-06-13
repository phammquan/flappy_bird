using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private float countDownToReplay = 5;
    [SerializeField] private TextMeshProUGUI scoreText;
    private float countDown;
    private int score = 0;

    void Start()
    {
        countDown = countDownToReplay;
    }

    private void Update()
    {
        if (Time.timeScale == 0)
        {
            CoutDownToReplay();
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    private void CoutDownToReplay()
    {
        countDown -= Time.unscaledDeltaTime;
        if (countDown <= 0)
        {
            RePlay();
            countDown = countDownToReplay;
        }
    }

    private void RePlay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
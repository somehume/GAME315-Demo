using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerTen : MonoBehaviour
{
    public static int score = 0;
    public static bool isGameOver = false;

    private float timeRemaining = 60f;

    void Update()
    {
        if (isGameOver) return;

        timeRemaining -= Time.deltaTime;
        UIManagerTen.UpdateTimer(Mathf.CeilToInt(timeRemaining));

        if (timeRemaining <= 0f)
        {
            EndGame();
        }
    }

    public static void AddScore()
    {
        if (!isGameOver)
        {
            score++;
            UIManagerTen.UpdateScore(score);
        }
    }

    private void EndGame()
    {
        isGameOver = true;
        UIManagerTen.ShowFinalScore(score);
    }
}
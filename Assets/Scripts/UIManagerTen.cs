using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class UIManagerTen : MonoBehaviour
{
    public static UIManagerTen instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject finalPanel;
    public TextMeshProUGUI finalScoreText;

    void Awake()
    {
        instance = this;
        UpdateScore(0);
    }

    public static void UpdateScore(int score)
    {
        instance.scoreText.text = $"Score: {score}";
    }

    public static void UpdateTimer(int seconds)
    {
        instance.timerText.text = $"Time: {seconds}";
    }

    public static void ShowFinalScore(int score)
    {
        instance.finalPanel.SetActive(true);
        instance.finalScoreText.text = $"Final Score: {score}";
    }
}
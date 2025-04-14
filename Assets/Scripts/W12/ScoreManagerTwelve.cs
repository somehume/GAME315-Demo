using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManagerTwelve : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void OnEnable() => EnemyTwelve.OnEnemyDefeated += AddScore;
    void OnDisable() => EnemyTwelve.OnEnemyDefeated -= AddScore;

    void AddScore()
    {
        score += 100;
        if (scoreText != null)
            scoreText.text = $"Score: {score}";
    }
}
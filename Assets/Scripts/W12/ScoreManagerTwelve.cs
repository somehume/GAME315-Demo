using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerTwelve : MonoBehaviour
{
    public Text scoreText;
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
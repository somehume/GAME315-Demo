using UnityEngine;

public class Coin : MonoBehaviour
{
    private ScoreDisplay scoreDisplay;

    void Start()
    {
        scoreDisplay = GameObject.FindObjectOfType<ScoreDisplay>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            scoreDisplay.AddScore(10);
            Destroy(gameObject);
        }
    }
}
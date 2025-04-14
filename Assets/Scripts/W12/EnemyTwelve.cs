using UnityEngine;
using System;

public class EnemyTwelve : MonoBehaviour
{
    public static event Action OnEnemyDefeated;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnEnemyDefeated?.Invoke();
            Destroy(gameObject);
        }
    }
}
using UnityEngine;
using System;

public class CoinCollectorTwelve : MonoBehaviour
{
    public static event Action OnCoinCollected;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            OnCoinCollected?.Invoke();
        }
    }
}
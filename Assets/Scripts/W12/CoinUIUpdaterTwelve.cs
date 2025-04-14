using UnityEngine;
using UnityEngine.UI;

public class CoinUIUpdaterTwelve : MonoBehaviour
{
    public Text coinText;
    private int coinCount = 0;

    void OnEnable() => CoinCollectorTwelve.OnCoinCollected += UpdateUI;
    void OnDisable() => CoinCollectorTwelve.OnCoinCollected -= UpdateUI;

    void UpdateUI()
    {
        coinCount++;
        if (coinText != null)
            coinText.text = $"Coins: {coinCount}";
    }
}
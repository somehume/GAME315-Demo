// CoinSpawnerTwelve.cs
using UnityEngine;

public class CoinSpawnerTwelve : MonoBehaviour
{
    public GameObject coinPrefab;
    public int numberOfCoins = 5;
    public Vector2 spawnMin = new Vector2(-8, -4);
    public Vector2 spawnMax = new Vector2(8, 4);

    void Start()
    {
        SpawnCoins();
    }

    public void SpawnCoins()
    {
        for (int i = 0; i < numberOfCoins; i++)
        {
            Vector2 pos = new Vector2(
                Random.Range(spawnMin.x, spawnMax.x),
                Random.Range(spawnMin.y, spawnMax.y)
            );
            Instantiate(coinPrefab, pos, Quaternion.identity);
        }
    }
}

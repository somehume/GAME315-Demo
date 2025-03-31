using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTen : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public float spawnInterval = 2f;
    public int maxCollectibles = 5;

    private float timer;

    void Update()
    {
        if (GameManagerTen.isGameOver) return;

        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;

            // 🔄 Use the static counter instead of finding GameObjects
            if (CollectibleTen.activeCount < maxCollectibles)
            {
                Vector2 spawnPos = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
                Instantiate(collectiblePrefab, spawnPos, Quaternion.identity);
            }
        }
    }
}
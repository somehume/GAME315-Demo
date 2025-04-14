// EnemySpawnerTwelve.cs
using UnityEngine;
using System.Collections;

public class EnemySpawnerTwelve : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector2 spawnMin = new Vector2(-8, -3);
    public Vector2 spawnMax = new Vector2(8, 3);
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 3f;

    private void OnEnable()
    {
        EnemyTwelve.OnEnemyDefeated += ScheduleRespawn;
    }

    private void OnDisable()
    {
        EnemyTwelve.OnEnemyDefeated -= ScheduleRespawn;
    }

    void ScheduleRespawn()
    {
        float delay = Random.Range(minSpawnDelay, maxSpawnDelay);
        Debug.Log($"Enemy defeated! Spawning new enemy in {delay} seconds...");
        StartCoroutine(SpawnAfterDelay(delay));
    }

    IEnumerator SpawnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        Vector2 spawnPos = new Vector2(
            Random.Range(spawnMin.x, spawnMax.x),
            Random.Range(spawnMin.y, spawnMax.y)
        );

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}

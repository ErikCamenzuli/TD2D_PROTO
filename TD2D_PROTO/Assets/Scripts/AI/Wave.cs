using UnityEngine;

public class Wave : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    public float spawnOffset = 1f;

    private float countdown = 2f;
    private int currentWave = 1;

    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0f)
        {
            SpawnWave();
            countdown = timeBetweenWaves;
            currentWave++;
        }
    }

    void SpawnWave()
    {
        int enemiesToSpawn = GetEnemiesForWave(currentWave);

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Vector3 spawnPosition = spawnPoint.position + new Vector3(i * spawnOffset, 0, 0);
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }

    int GetEnemiesForWave(int waveNumber)
    {
        return 3 + (waveNumber - 1) * 2;
    }
}

using UnityEngine;

public class Waves : MonoBehaviour
{
    public GameObject enemyPrefab;      // Prefab of the enemy to spawn
    public Transform spawnPoint;       // Location to start spawning enemies
    public int enemiesPerWave = 5;     // Number of enemies in each wave
    public float spawnInterval = 0.5f; // Delay between each spawn
    public float spawnOffset = 1f;     // Distance between enemies along the X-axis

    private void Start()
    {
        SpawnWave(); // Automatically spawn a wave on start for testing
    }

    public void SpawnWave()
    {
        StartCoroutine(SpawnEnemies());
    }

    private System.Collections.IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < enemiesPerWave; i++)
        {
            // Calculate the position for each enemy, with a horizontal offset
            Vector3 spawnPosition = spawnPoint.position + new Vector3(i * spawnOffset, 0, 0);

            // Instantiate the enemy at the calculated position
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            // Wait before spawning the next enemy
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
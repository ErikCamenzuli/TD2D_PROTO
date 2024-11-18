using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int pointsOnDeath = 10;
    private UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        if (uiManager == null)
        {
            Debug.LogError("UIManager not found in the scene!");
        }
    }

    public void TakeDamage(int damage)
    {
        Destroy(gameObject);

        if (uiManager != null)
        {
            Debug.Log("Enemy destroyed. Adding points: " + pointsOnDeath);
            uiManager.AddPoints(pointsOnDeath);
        }
    }
}

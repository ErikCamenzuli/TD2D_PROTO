using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text pointsText;
    private int points = 100;

    public void AddPoints(int amount)
    {
        points += amount;
        Debug.Log("Points updated to: " + points);
        UpdatePointsUI();
    }


    private void UpdatePointsUI()
    {
        if (pointsText != null)
        {
            pointsText.text = "Points: " + points;
        }
        else
        {
            Debug.LogError("Points Text is not assigned in the UIManager!");
        }
    }

}

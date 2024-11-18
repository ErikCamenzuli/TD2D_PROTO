using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int energy = 100;

    public void SpendEnergy(int amount)
    {
        if (energy >= amount)
        {
            energy -= amount;
        }
    }

    public void GainEnergy(int amount)
    {
        energy += amount;
    }
}

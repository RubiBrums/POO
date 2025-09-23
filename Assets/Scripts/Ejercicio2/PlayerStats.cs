using UnityEngine;

public class PlayerStats
{
    private int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    public void Heal(int healPoints)
    {
        health += healPoints;
    }

    public void PrintHealth()
    {
        Debug.Log("Health: " + health);
    }
}

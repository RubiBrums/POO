using UnityEngine;

public class PlayerStats
{

    private int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    public void Heal(int healthPoints)
    {
        health += healthPoints;
    }

    public void PrintHealth()
    {
        Debug.Log("Salud: " + health);
    }
}

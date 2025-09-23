using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    void Start()
    {
        PlayerStats playerStats1 = new PlayerStats();
        playerStats1.TakeDamage(50);
        playerStats1.PrintHealth();
        playerStats1.Heal(25);
        playerStats1.PrintHealth();
    }

}

using JetBrains.Annotations;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    void Start()
    {
        PlayerStats player1 = new PlayerStats();
        player1.TakeDamage(50);
        player1.PrintHealth();

        player1.Heal(25);
        player1.PrintHealth();
    }


}

using UnityEngine;

public class GameManager3 : MonoBehaviour
{
    void Start()
    {
        Enemy orc = new Enemy("Orc", 200);
        orc.Show();
        Enemy dragon = new Enemy("", 0)
        {
            enemyName = "Dragon",
            enemyHP = 500
        };
        dragon.Show();
    }

}

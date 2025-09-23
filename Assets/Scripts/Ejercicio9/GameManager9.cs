using System.Collections.Generic;
using UnityEngine;

public class GameManager9 : MonoBehaviour
{
    List<EnemyBase> enemigos = new List<EnemyBase>();
    void Start()
    {
        EnemyBase enemy = new EnemyBase();
        EnemyBase enemy2 = new EnemyBase();
        Zombie zombie = new Zombie();
        Zombie zombie2 = new Zombie();
        Skeleton skeleton = new Skeleton();
        Skeleton skeleton2 = new Skeleton();
        
        enemigos.Add(enemy);
        enemigos.Add(enemy2);
        enemigos.Add(zombie);
        enemigos.Add(zombie2);
        enemigos.Add(skeleton);
        enemigos.Add(skeleton2);

        foreach (EnemyBase e in enemigos)
        {
            e.Shout();
        }


    }
}

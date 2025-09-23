using UnityEngine;

public class GameManager10 : MonoBehaviour
{
    void Start()
    {
        Enemigo enemigo = new Enemigo();
        Jefe jefe = new Jefe();

        enemigo.TakeDamage(50);
        jefe.TakeDamage(99);
        enemigo.TakeDamage(50);
        jefe.TakeDamage(1);
    }
}

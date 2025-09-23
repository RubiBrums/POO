using UnityEngine;

public class Enemigo : Entity
{
    public override void Die()
    {
        Debug.Log("El Enemigo ha muerto");
    }
}

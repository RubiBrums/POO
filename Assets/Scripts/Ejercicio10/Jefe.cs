using UnityEngine;

public class Jefe : Enemigo
{
    public override void Die()
    {
        Debug.Log("El Jefe ha muerto");
    }
}

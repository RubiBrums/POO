using UnityEngine;

public class Personaje
{
    public string personajeName;
    public int personajeHP;

    public virtual void Attack()
    {
        Debug.Log("Ataque Normal");
    }
}

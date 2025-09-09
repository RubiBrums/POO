using UnityEngine;

public class Warrior : Personaje
{
    public int Strength;

    public void DescripcionWarrior()
    {
        Descripcion();
        Debug.Log("Fuerza: " + Strength);
    }
}

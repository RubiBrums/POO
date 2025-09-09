using UnityEngine;

public class Mage : Personaje
{
    public int Mana;

    public void DescripcionMage()
    {
        Descripcion();
        Debug.Log("Maná: " + Mana);
    }

}

using UnityEngine;

public class Weapon
{
    public string nombreWeapon;
    public int dano;
    public void mostrarInfo()
    {
        Debug.Log("Nombre: " + nombreWeapon + " - Daño: " + dano);
    }


}

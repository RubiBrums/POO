using UnityEngine;

public class Weapon
{
    public string weaponName;
    public int damage;

    public void ShowInfo()
    {
        Debug.Log("Información - Nombre: "+ weaponName + " - Daño: " + damage);
    }
    
}

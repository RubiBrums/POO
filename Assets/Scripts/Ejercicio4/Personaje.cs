using UnityEngine;

public class Personaje
{
    public string characterName;
    public int characterHP;

    public void Descripcion()
    {
        Debug.Log("Nombre: " + characterName);
        Debug.Log("HP: " + characterHP);
    }
}

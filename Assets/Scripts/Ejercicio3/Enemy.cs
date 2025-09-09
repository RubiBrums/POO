using UnityEngine;

public class Enemy
{
    public string nombre;
    public int hp;


    public Enemy(string Nombre, int HP)
    {
        nombre = Nombre;
        hp = HP;
    }
    public void Show()
    {
        Debug.Log("Nombre: " + nombre + " - HP: " + hp);
    }

}

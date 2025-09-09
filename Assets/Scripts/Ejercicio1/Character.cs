using UnityEngine;

public class Character : MonoBehaviour
{
    public string Nombre;
    public int HP;
    public string Job;


    /*public void ShowName()
    {
        Debug.Log("Nombre: " + Nombre);
    }*/

    public Character(string nombre, int hp)
    {
        Nombre = nombre;
        HP = hp;
        Debug.Log("Nombre: " + Nombre + " - HP: " + HP);
    }
    
}

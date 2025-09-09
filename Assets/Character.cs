using UnityEngine;

public class Character : MonoBehaviour
{
    public string Nombre;
    public int HP;
    public string Job;


    public void ShowName()
    {
        Debug.Log("Nombre: " + Nombre);
    }
    
}

using UnityEngine;

public class Warrior : Personaje
{
    public int fuerza;

    public void DescriptionGuerrero()
    {
        Debug.Log("Nombre: " + personajeName + " - Salud: " + personajeHP + " - Fuerza: " + fuerza);
    } 
    
    public override void Attack()
    {
        Debug.Log("Ataque con Espada");
    }  
}

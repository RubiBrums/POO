using UnityEngine;

public class Mago : Personaje
{
    public int mana;

    public void DescriptionMago()
    {
        Debug.Log("Nombre: " + personajeName + " - Salud: " + personajeHP + " - Mana: " + mana);
    }

    public override void Attack()
    {
        Debug.Log("Ataque con magia");
    }
}

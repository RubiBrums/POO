using UnityEngine;

public class GameManager4 : MonoBehaviour
{
    void Start()
    {
        Warrior guerrero = new Warrior()
        {
            personajeName = "Guerrero",
            personajeHP = 200,
            fuerza = 300
        };

        guerrero.DescriptionGuerrero();

        Mago mago = new Mago()
        {
            personajeName = "Mago",
            personajeHP = 120,
            mana = 500
        };

        mago.DescriptionMago();


    }

}

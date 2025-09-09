using UnityEngine;

public class GameManager4 : MonoBehaviour
{
    void Start()
    {
        Warrior guerrero = new Warrior()
        {
            characterName = "Guerrero",
            characterHP = 200,
            Strength = 300
        };

        guerrero.DescripcionWarrior();

        Mage mago = new Mage()
        {
            characterName = "Mago",
            characterHP = 120,
            Mana = 500
        };

        mago.DescripcionMage();


    }

}

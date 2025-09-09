using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        Weapon cuchillo = new Weapon()
        {
            nombreWeapon = "Cuchillo",
            dano = 10
        };
        cuchillo.mostrarInfo();

        Weapon arco = new Weapon()
        {
            nombreWeapon = "Arco",
            dano = 20
        };
        arco.mostrarInfo();
    }


}

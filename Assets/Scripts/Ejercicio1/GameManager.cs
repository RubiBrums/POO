using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Weapon sword = new Weapon()
        {
            weaponName = "Sword",
            damage = 100
        };
        sword.ShowInfo();

        Weapon axe = new Weapon()
        {
            weaponName = "Axe",
            damage = 150
        };
        axe.ShowInfo();
    }
}

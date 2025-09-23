using UnityEngine;

public class GameManager8 : MonoBehaviour
{
    void Start()
    {
        Gun arma = new Gun()
        {
            gunName = "Piumpium",
            bullet = new Bullet()
            {
                damage = 100,
                speed = 200
            }
        };
        arma.Describe();
        
    }

}

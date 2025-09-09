using UnityEngine;

public class GameManager3 : MonoBehaviour
{
    void Start()
    {
        Enemy enemigo1 = new Enemy("Bruja", 200);
        enemigo1.Show();

        Enemy enemigo2 = new Enemy("", 0)
        {
            nombre = "Ogro",
            hp = 150
        };
        enemigo2.Show();
    }

}

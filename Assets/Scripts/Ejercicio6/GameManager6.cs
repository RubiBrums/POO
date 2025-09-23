using UnityEngine;

public class GameManager6 : MonoBehaviour
{
    void Start()
    {
        Inventory inventory = new Inventory();
        inventory.PrintGold();
        inventory.SpendGold(1100);
        inventory.SpendGold(500);
        inventory.PrintGold();
        inventory.AddGold(-1000);
        inventory.AddGold(1000);
        inventory.PrintGold();
        
    }
}

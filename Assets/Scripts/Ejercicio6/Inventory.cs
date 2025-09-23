using Unity.VisualScripting;
using UnityEngine;

public class Inventory
{
    private int gold = 1000;

    public void AddGold(int goldAdd)
    {
        if (goldAdd < 0)
        {
            Debug.Log("El oro debe ser positivo");
        }
        else
        {
            gold += goldAdd;
        }
    }

    public void SpendGold(int goldSpend)
    {
        if (gold < goldSpend)
        {
            Debug.Log("No tiene suficiente oro");
        }
        else
        {
            gold -= goldSpend;
        }
    }
    public void PrintGold()
    {
        Debug.Log("Te queda: " + gold + "G");
    }
}

using UnityEngine;

public class Pet
{
    private int happiness = 0;

    public void Happiness()
    {
        if (happiness > 100)
        {
            happiness = 100;
        }

        else if (happiness < 0)
        {
            happiness = 0;
        } 
    }

    public void Play(int happyPoints)
    {
        happiness += happyPoints;
        Happiness();
        Debug.Log("Puntos de Felicidad: " + happiness);
    }

    
}

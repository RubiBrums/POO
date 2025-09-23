using UnityEngine;

public class Bullet
{
    public int damage;
    public int speed;

    public void Describe()
    {
        Debug.Log("Daño: " + damage + " Velocidad: " + speed);
    }
    
}

using UnityEngine;

public class Gun
{
    public string gunName;
    public Bullet bullet;

    public void Describe()
    {
        Debug.Log("Arma: " + gunName);
        bullet.Describe();
    }
    
}

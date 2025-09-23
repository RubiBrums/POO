using UnityEngine;

public class Enemy
{
    public string enemyName;
    public int enemyHP;

    public Enemy(string name, int hp)
    {
        enemyName = name;
        enemyHP = hp;
    }

    public void Show()
    {
        Debug.Log("Nombre: " + enemyName);
        Debug.Log("HP: " + enemyHP);
    }
    
}

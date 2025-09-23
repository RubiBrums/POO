using UnityEngine;

public class Entity
{
    private int hp = 100;
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
        else
        {
            Debug.Log("El personaje sigue vivo");
        }

    }
    public virtual void Die()
    {
        Debug.Log("Tu Entidad ha muerto");
    }
}

using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GameManager5 : MonoBehaviour
{
    List <Personaje> personajes = new List <Personaje>();
    void Start()
    {
        Personaje personaje1 = new Mago();
        Personaje personaje2 = new Warrior();
        Personaje personaje3 = new Personaje();
        
        personajes.Add(personaje1);
        personajes.Add(personaje2);
        personajes.Add(personaje3);

        foreach (Personaje p in personajes)
        {
            p.Attack();
        }

    }

}

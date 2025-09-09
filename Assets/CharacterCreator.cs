using UnityEngine;

public class CharacterCreator : MonoBehaviour
{

    Character npc1 = new Character();
    Character player1 = new Character();
    Character enemy1 = new Character();

    void Start()
    {
        NPC();
    }

    void NPC()
    {
        npc1.Nombre = "Pepito";
        npc1.HP = 100;
        npc1.Job = "Granjero";
        npc1.ShowName(); 
    }
}

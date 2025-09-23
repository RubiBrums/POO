using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name;
    public int HP;
    public string Job;

    public void ShowName()
    {
        Debug.Log("Nombre: " + Name);
    }
}

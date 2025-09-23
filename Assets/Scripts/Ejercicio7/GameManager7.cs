using UnityEngine;

public class GameManager7 : MonoBehaviour
{
    void Start()
    {
        Pet mascota = new Pet();
        mascota.Play(-100);
        mascota.Play(99);
        mascota.Play(200);
    }
}

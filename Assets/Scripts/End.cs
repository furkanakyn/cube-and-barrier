using UnityEngine;

public class End : MonoBehaviour
{
    public GameManager gamem;

    void OnTriggerEnter()
    {
        gamem.completelvl();
    }
}

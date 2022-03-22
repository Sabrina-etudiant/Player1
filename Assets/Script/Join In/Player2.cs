using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour
{
    void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("Player2");
    }

}

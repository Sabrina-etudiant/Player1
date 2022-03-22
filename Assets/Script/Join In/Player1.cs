using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : MonoBehaviour
{
    void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("Player1");
    }

}
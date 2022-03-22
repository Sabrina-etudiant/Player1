using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSolo : MonoBehaviour
{
    void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("PlayerSolo");
    }
}

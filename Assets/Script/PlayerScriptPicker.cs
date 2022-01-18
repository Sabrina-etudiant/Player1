using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScriptPicker : MonoBehaviour
{
    public GameObject Player, player2;//déclare 

    private void Start()//ce lance si joueur apparait dans la scene 
    {
        if (PlayerInputManager.instance.playerCount == 1)//si player input =1

        {
            Instantiate(Player, transform);
        }
        else//sinon
        {
            Instantiate(player2, transform);
        }
    }
}

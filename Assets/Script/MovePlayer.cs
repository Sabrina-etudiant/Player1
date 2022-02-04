using UnityEngine.InputSystem;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float speed;
    Vector2 stickdirection;
    Rigidbody2D rb;

    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        var stick2d = new Vector2(stickdirection.x, stickdirection.y);
        rb.velocity = stick2d * speed;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        var move = context.ReadValue<Vector2>();
        stickdirection = move;

    }
    /*
     private void OnMove(InputValue value)
    {
        stickdirection = value.Get<Vector2>();
    }*/
}

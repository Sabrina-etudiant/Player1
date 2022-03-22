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


    void FixedUpdate()
    {
        rb.velocity = stickdirection * speed;
    }

    void OnMove(InputValue context)
    {
        stickdirection = context.Get<Vector2>();
        Debug.Log(stickdirection);
    }
}
    /*
     private void OnMove(InputValue value)
    {
        stickdirection = value.Get<Vector2>();
    }*/


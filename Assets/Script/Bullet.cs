using UnityEngine.InputSystem;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public int damage = 40; 

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed; 
    }
    void Update()
    {
        
    }
}

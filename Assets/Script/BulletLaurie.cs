using UnityEngine.InputSystem;
using UnityEngine;

public class BulletLaurie : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    public int damage = 40;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}

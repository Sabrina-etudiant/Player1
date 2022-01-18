using UnityEngine.InputSystem;
using UnityEngine;

public class Arme : MonoBehaviour
{
    public Transform point;
    public GameObject BulletPrefab;
    Rigidbody2D rb;
    [SerializeField] float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    
    void Update()
    {
        
    }
    public void OnShoot(InputValue value)
    {
        Instantiate(BulletPrefab, point.position, point.rotation);
    }
   
}

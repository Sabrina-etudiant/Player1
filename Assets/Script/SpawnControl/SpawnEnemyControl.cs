using UnityEngine.InputSystem;
using UnityEngine;
using System.Collections;

public class SpawnEnemyControl : MonoBehaviour
{
    public Transform point;
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;
    public GameObject enemyPrefab4;
    public GameObject explosionPrefab;
    Rigidbody2D rb;
    public float cooldown;
    float lastShoot;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Enemy1(InputAction.CallbackContext context)
    {
        //wait for cooldown (set time) to end
        if (Time.time - lastShoot < cooldown)
            return;
        lastShoot = Time.time;
        Instantiate(enemyPrefab1, point.position, point.rotation);
    }
    public void Enemy2(InputAction.CallbackContext context)
    {
        //wait for cooldown (set time) to end
        if (Time.time - lastShoot < cooldown)
            return;
        lastShoot = Time.time;
        Instantiate(enemyPrefab2, point.position, point.rotation);
    }
    public void Enemy3(InputAction.CallbackContext context)
    {
        //wait for cooldown (set time) to end
        if (Time.time - lastShoot < cooldown)
            return;
        lastShoot = Time.time;
        Instantiate(enemyPrefab3, point.position, point.rotation);
    }
    public void Enemy4(InputAction.CallbackContext context)
    {
        //wait for cooldown (set time) to end
        if (Time.time - lastShoot < cooldown)
            return;
        lastShoot = Time.time;
        Instantiate(enemyPrefab4, point.position, point.rotation);
    }
    public void DogCapacity(InputAction.CallbackContext context)
    {
        //Appeler le script

        foreach (var gameObj in GameObject.FindGameObjectsWithTag("Dog"))
        {
            Instantiate(explosionPrefab, gameObj.transform.position, Quaternion.identity);
            Destroy(gameObj);
            Debug.Log("lol");
        }
    }

}

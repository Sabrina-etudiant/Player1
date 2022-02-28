using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class aleatoireSpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] EnnemyTestPrefabTest;

    void Start()
    {
        
    }

    
    public void Spawn (InputAction.CallbackContext context)
    {
            
       
            int randEnnemy = Random.Range(0, EnnemyTestPrefabTest.Length);
            int randspawnPoint = Random.Range(0, spawnPoint.Length);

            Instantiate(EnnemyTestPrefabTest[0], spawnPoint [randspawnPoint].position , transform.rotation);
        
    }
}

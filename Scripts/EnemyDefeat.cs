using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDefeat : MonoBehaviour
{
    public Rigidbody enemyRib;
    void Start()
    {
        enemyRib = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enemyRib.transform.position = new Vector3(Random.Range(-10, -10), 0, Random.Range(-11, -13));
          

        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDefeat4 : MonoBehaviour
{
    public Rigidbody enemyRib4;
    // Start is called before the first frame update
    void Start()
    {
        enemyRib4 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            enemyRib4.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-13, -14));

        }
    }
}

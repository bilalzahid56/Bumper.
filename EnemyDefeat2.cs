using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDefeat2 : MonoBehaviour
{
    public Rigidbody enemyRib2;
    // Start is called before the first frame update
    void Start()
    {
        enemyRib2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            enemyRib2.transform.position = new Vector3(Random.Range(-13, -14), 0, Random.Range(-10, 10));
            

        }
    }
}

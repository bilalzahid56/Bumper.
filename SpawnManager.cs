using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
   


    void Start()
    {
       // enemyPrebs = GetComponent<Rigidbody>();

        InvokeRepeating("EnemySpawnEveryTime1", 5f,5f);
        InvokeRepeating("EnemySpawnEveryTime2", 14f, 14f);
        InvokeRepeating("EnemySpawnEveryTime3", 18f, 18f);
        InvokeRepeating("EnemySpawnEveryTime4", 24f, 24f);
 
    }

    private Vector3 RandomValues()
    {    
       Vector3 randomValues = new Vector3(Random.Range(-11, 11), 0, Random.Range(-11, 11));
       
        return randomValues;
     }

    public  void EnemySpawnEveryTime1()
    {
        Instantiate(enemyPrefab[0], RandomValues(), transform.rotation);         
    }
    public void EnemySpawnEveryTime2()
    {
        Instantiate(enemyPrefab[1], RandomValues(), transform.rotation);
    }
    public void EnemySpawnEveryTime3()
    {
        Instantiate(enemyPrefab[2], RandomValues(), transform.rotation);
    }
    public void EnemySpawnEveryTime4()
    {
        Instantiate(enemyPrefab[3], RandomValues(), transform.rotation);
    }


  
}

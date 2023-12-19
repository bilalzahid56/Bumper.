using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_followPlayer : MonoBehaviour
{
    private int speed = 3;
   public Rigidbody enemyrb;
    private GameObject player;
    private SpawnManager enemy;

    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
       
    }


    void Update()
    {
        Vector3 lookDIrection = (player.transform.position - transform.position).normalized ;

        enemyrb.AddForce(lookDIrection * speed);
        
    }
   
}


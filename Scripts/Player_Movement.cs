using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private Rigidbody playerRB;
    public GameObject player;
    [SerializeField] private int speedVertical = 7;
    [SerializeField] private int speedHorizontal = 6;
    private Vector3 reset = new Vector3(0, 0, 0);
    private SpawnManager enemy;
    // private Vector3 randomX = new Vector3(Random.Range(-14,-17), 0, 0);
    // private Vector3 randomZ = new Vector3(0, 0, Random.Range(-14, 17));

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        //enemy = GetComponent<GameObject>();



    }
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");
        playerRB.AddForce(Vector3.forward * speedVertical * forwardInput);
        playerRB.AddForce(Vector3.right * speedHorizontal * rightInput);

        if (player.transform.position.y < -2)
        {
            player.transform.localScale -= new Vector3(.1f, .1f, .1f);
            player.transform.position = reset;


        }




    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            // Increase the scale of the player's ball
            transform.localScale += new Vector3(.1f, .1f, .1f);

        }

    }

}


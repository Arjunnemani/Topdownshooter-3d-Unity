using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{
    private Rigidbody myRB;
    public float moveSpeed;
    public Move thePlayer;

    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<Move>();
    }
    private void FixedUpdate()
    {
        myRB.velocity = (transform.forward * moveSpeed);
    }


    void Update()
    {
        transform.LookAt(thePlayer.transform.position); 
    }
}

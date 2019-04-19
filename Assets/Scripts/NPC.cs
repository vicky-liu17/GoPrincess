using System;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("You have to find a key");
            print(myRigidbody.position);
        }
            
    }

}
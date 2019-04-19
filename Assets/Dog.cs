using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("meet dog");
        //Transform transform = GameObject.FindGameObjectWithTag("dog_unseen").transform;
        Transform transform = GameObject.FindGameObjectWithTag("Dog_thought_pos").transform;

        //Instantiate(itemButton, transform, false);
        Instantiate(itemButton, transform, false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public float spawnTime = 2;
    void Start()
    {
        InvokeRepeating("addEnemy", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addEnemy()
{
Renderer rd = GetComponent<Renderer>();
float s = rd.bounds.size.x / 2;
// Variables to store the X position of the spawn object
float x1 = transform.position.x - s;
float x2 = transform.position.x + s;
// Randomly pick a point within the spawn object
Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
// Create an enemy at the 'spawnPoint' position
Instantiate(enemy, spawnPoint, Quaternion.identity);
}
}

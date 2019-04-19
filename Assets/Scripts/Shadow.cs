using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    // Start is called before the first frame update
    int healthPointsToDeduct = 6;
    void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D obj){
        Debug.Log(1);
        HealthPointManager.DeductHealthPoint(healthPointsToDeduct);
    }
}

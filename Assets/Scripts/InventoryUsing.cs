using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUsing : MonoBehaviour
{
    private Transform player;

    public int healthPointsToAdd;

    private void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
    }


    public void Use ()
    {
        HealthPointManager.AddHealthPoints(healthPointsToAdd);
        Destroy(gameObject);
    }



}

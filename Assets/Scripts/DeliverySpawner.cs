using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DeliverySpawner : MonoBehaviour
{
    public Transform[] SpawnPoints = new Transform[5];

    public GameObject DeliverySpot;

    private int randomPoint;
    private Transform decidedPoint;

    private void Start()
    {
        SpawnDelivery();
    }
    public void SpawnDelivery()
    {
        randomPoint = UnityEngine.Random.Range(0, 5);
        decidedPoint = SpawnPoints[randomPoint];

        Instantiate(DeliverySpot, decidedPoint.position, transform.rotation);
        
    }
}

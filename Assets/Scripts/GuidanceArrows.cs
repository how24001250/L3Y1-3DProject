using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class GuidanceArrows : MonoBehaviour
{
    private GameObject deliveryPoint;

    //DeliverySpot(Clone)
    void Update()
    {
        deliveryPoint = GameObject.Find("DeliverySpot(Clone)");

        transform.LookAt(deliveryPoint.transform);
    }
}

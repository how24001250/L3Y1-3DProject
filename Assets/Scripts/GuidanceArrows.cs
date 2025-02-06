using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class GuidanceArrows : MonoBehaviour
{
    private GameObject deliveryPoint;
    public GameObject pickupPoint;

    //DeliverySpot(Clone)
    //PickupPoint

    void Update()
    {
        if (GameObject.Find("Car").GetComponent<CarController>().hasPackage == true) 
        {
            deliveryPoint = GameObject.Find("DeliverySpot(Clone)");
            transform.LookAt(deliveryPoint.transform);
        }
        else if (GameObject.Find("Car").GetComponent<CarController>().hasPackage == false) 
        {
            pickupPoint = GameObject.Find("PickupPoint");
            transform.LookAt(pickupPoint.transform);
        }
        
    }
}

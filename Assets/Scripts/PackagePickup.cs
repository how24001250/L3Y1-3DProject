using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackagePickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            GameObject.Find("Car").GetComponent<CarController>().hasPackage = true;
        }
    }
}

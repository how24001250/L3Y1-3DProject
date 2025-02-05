using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    public int packagesDelivered;
    public TextMeshProUGUI packagesText;


    private void Start() {
        packagesDelivered = GameManager.packagesDelivered;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected");

        if(GameObject.Find("Car").GetComponent<CarController>().hasPackage == true) {
            Debug.Log("Delivered!");
            GameManager.packagesDelivered++;
            GameObject.Find("Car").GetComponent<CarController>().hasPackage = false;
            GameObject.Find("GameManager").GetComponent<DeliverySpawner>().SpawnDelivery();

            Destroy(gameObject);
        }
        
    }
}

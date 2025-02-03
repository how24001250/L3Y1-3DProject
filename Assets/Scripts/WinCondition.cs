using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public int packagesDelivered;
    public TextMeshProUGUI packagesText;
    private void Start() {
        packagesDelivered = GameObject.Find("GameManager").GetComponent<GameManager>().packagesDelivered;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected");

        if(GameObject.Find("Car").GetComponent<CarController>().hasPackage == true) {
            Debug.Log("Delivered!");
            GameObject.Find("GameManager").GetComponent<GameManager>().packagesDelivered++;
            GameObject.Find("Car").GetComponent<CarController>().hasPackage = false;
            Destroy(gameObject);
        }
        
    }
}

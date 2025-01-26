using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameObject.Find("Car").GetComponent<CarController>().jumpHeight = 30;
            Destroy(gameObject);
        }
        
    }
}

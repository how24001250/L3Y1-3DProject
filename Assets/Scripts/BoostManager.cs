using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostManager : MonoBehaviour
{
    [Header("Boost")]
    public float boostAmount = 2f; // Speed increase amount
    public float boostDuration = 2f; // Duration of the boost
    

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnterBOOOOOOST");

        if (other.CompareTag("Player") && GameObject.Find("Car").GetComponent<CarController>().isBoosted == false)
        {
            StartCoroutine(BoostSpeed());
        }
    }

    private IEnumerator BoostSpeed()
    {
        GameObject.Find("Car").GetComponent<CarController>().isBoosted = true;
        GameObject.Find("Car").GetComponent<CarController>().forwardAccel = GameObject.Find("Car").GetComponent<CarController>().forwardAccel * boostAmount;
        Debug.Log("BOOOOOST!!!!!!!!!");
        yield return new WaitForSeconds(boostDuration);
        GameObject.Find("Car").GetComponent<CarController>().forwardAccel = GameObject.Find("Car").GetComponent<CarController>().forwardAccel / boostAmount;
        GameObject.Find("Car").GetComponent<CarController>().isBoosted = false;
    }
}

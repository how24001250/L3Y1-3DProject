using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Football : MonoBehaviour
{
    public TextMeshProUGUI scoreBoard;
    public int homeGoals = 0;
    public int awayGoals = 0;

    public Vector3 center = new Vector3(59.78f, 0.64f, 4.4f);

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "HomeNet")
        {
            homeGoals++;
            ResetPositionAndStop();
        }
        if (other.tag == "AwayNet")
        {
            awayGoals++;
            ResetPositionAndStop();
        }
        else if (other.tag != "HomeNet" && other.tag != "AwayNet")
        {
            ResetPositionAndStop();
        }

    }

    private void Update()
    {
        scoreBoard.text = homeGoals + ":" + awayGoals;
    }

    void ResetPositionAndStop()
    {
        transform.position = center;

        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    

}

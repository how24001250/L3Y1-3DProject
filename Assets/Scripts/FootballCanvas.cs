using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballCanvas : MonoBehaviour
{
    public Canvas fbCanvas;

    private void Start()
    {
        fbCanvas.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            fbCanvas.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            fbCanvas.enabled = false;
        }
    }
}

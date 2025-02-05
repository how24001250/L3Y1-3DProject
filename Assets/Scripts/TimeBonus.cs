using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBonus : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().timer += 5;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMenuSpin : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    [SerializeField] private float speed;

    void Update()
    {
        transform.Rotate(rotation * speed *  Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbine : MonoBehaviour
{
    float speed;


    private void Start()
    {
        speed = Random.Range(1, 10);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(speed, 0));
    }
}

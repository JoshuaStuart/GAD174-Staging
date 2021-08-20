using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbine : MonoBehaviour
{
    float speed;


    private void Start()
    {
        speed = Random.Range(10, 60);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(speed * Time.deltaTime, 0));
    }
}

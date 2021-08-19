using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] float rotateXSpeed;
    [SerializeField] float rotateYSpeed;
    [SerializeField] float rotateZSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        Vector3 rotateVector = new Vector3(rotateXSpeed, rotateYSpeed, rotateZSpeed);
        transform.Rotate(rotateVector * Time.deltaTime);
    }
}

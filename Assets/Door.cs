using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        gameObject.SetActive(false);

        Invoke("CloseDoor", 3f);
    }

    public void CloseDoor()
    {
        gameObject.SetActive(true);
    }
}

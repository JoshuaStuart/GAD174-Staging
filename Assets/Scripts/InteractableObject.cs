using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public AudioClip sound;
    public string objectName;

    private void OnMouseOver()
    {
        GameManager.instance.toolTip.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            GameManager.instance.toolTip.GetComponent<Text>().text = objectName;
            gameObject.AddComponent<AudioSource>();
            GetComponent<AudioSource>().clip = sound;

            GetComponent<AudioSource>().Play();
        }
    }
    private void OnMouseExit()
    {
        GameManager.instance.toolTip.GetComponent<Text>().text = "Click to Interact";
        GameManager.instance.toolTip.SetActive(false);
    }

}

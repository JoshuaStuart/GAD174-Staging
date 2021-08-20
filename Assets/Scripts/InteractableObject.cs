using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    public AudioClip sound;
    public string objectName;

    public UnityEvent interactionEvent;

    private void Start()
    {
        gameObject.AddComponent<AudioSource>();
        GetComponent<AudioSource>().clip = sound;
    }

    private void OnMouseOver()
    {
        GameManager.instance.toolTip.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            GameManager.instance.toolTip.GetComponent<Text>().text = objectName;

            GetComponent<AudioSource>().Play();

            interactionEvent?.Invoke();
        }
    }
    private void OnMouseExit()
    {
        GameManager.instance.toolTip.GetComponent<Text>().text = "Click to Interact";
        GameManager.instance.toolTip.SetActive(false);
    }

}

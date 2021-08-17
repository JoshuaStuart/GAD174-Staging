using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterArea : MonoBehaviour
{
    public GameObject UIText;
    //public GameObject Player;

   // public float fadeSpeed;
    //public float count = 1;

    private void Start()
    {
        UIText.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        UIText.SetActive(true);

           // if (count > 0)
           // { 
           //     Color32 textColour = UIText.GetComponent<Text>().color;
           //     count -= 0.01f * fadeSpeed * Time.deltaTime;
           //     UIText.GetComponent<Text>().color = new Color(textColour.r, textColour.g, textColour.b, count);
           // }
           //if (count < 0 || count == 0)
           // { 
           //     UIText.SetActive(false);
           // }
    }

    private void OnTriggerExit(Collider other)
    {
        UIText.SetActive(false);
    }
}

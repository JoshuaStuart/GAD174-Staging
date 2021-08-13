using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public GameObject panel;
    public GameObject text;

    public GameObject Player;

    public float fadeSpeed;
    public float count = 1;
    private void Update()
    {

        if(count > 0)
        {
            Color32 panelColour = panel.GetComponent<Image>().color;
            Color32 textColour = text.GetComponent<Text>().color;
            count -= 0.01f * fadeSpeed * Time.deltaTime;
            panel.GetComponent<Image>().color = new Color(panelColour.r, panelColour.g, panelColour.b, count);
            text.GetComponent<Text>().color = new Color(textColour.r, textColour.g, textColour.b, count);
        }
       if(count < 0 || count == 0)
        {
            panel.SetActive(false);
            text.SetActive(false);
            Player.GetComponent<PlayerMovement>().enabled = true;
        }
    }
}

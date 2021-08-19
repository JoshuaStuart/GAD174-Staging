using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterArea : MonoBehaviour
{
    public GameObject UIText;
    //public GameObject Player;

    public float fadeSpeed;
    public float count = 1;
    private bool isFading = true;

    private void Start()
    {
        UIText.SetActive(false);
    }

    private void Update()
    {
        FadeUI();
    }

    private void StartFadingUI()
    {
        isFading = true;
        count = 1;
    }

    private void FadeUI()
    {
        if (!isFading) return;
        
        if (count > 0)
        {
            Color32 textColour = UIText.GetComponent<Image>().color;
            count -= 0.01f * fadeSpeed * Time.deltaTime;
            UIText.GetComponent<Image>().color = new Color(textColour.r, textColour.g, textColour.b, count);
        }
        if (count < 0 || count == 0)
        {
            UIText.SetActive(false);
            isFading = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();

        if (playerMovement)
        {
            if(playerMovement.GetCanMoveStatus())
            {
                ShowUI();
                Invoke("StartFadingUI", 1f);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        UIText.SetActive(false);
        isFading = false;
    }

    private void ShowUI()
    {
        UIText.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        UIText.SetActive(true);
    }
}

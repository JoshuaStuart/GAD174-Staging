using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Camera.main.GetComponent<MouseLook>().enabled = false;
    }
    public void Return()
    {
        Cursor.visible = false;
        Camera.main.GetComponent<MouseLook>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        gameObject.SetActive(false);

    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void close()
    {
        Application.Quit();
        print("Quitting game..");
    }
}

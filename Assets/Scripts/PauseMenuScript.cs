using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }
    public void Return()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void close()
    {
        Application.Quit();
    }
}

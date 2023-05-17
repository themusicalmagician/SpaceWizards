using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject canvas;
    public void Play()
    {
        canvas.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
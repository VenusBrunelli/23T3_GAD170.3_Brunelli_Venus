using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Start Button Pressed. New Scene Loaded");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Button Pressed Quitting Game");
    }
}

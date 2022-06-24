using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Guide()
    {
        SceneManager.LoadScene("Guide");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OpenAuthor()
    {
        Debug.Log("William Tan - 149251970101-183");
    }

  
}

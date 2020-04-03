using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        
        Application.Quit();
    }

   public void HardGame()
    {
        SceneManager.LoadScene("Hard", LoadSceneMode.Single);
    }
    public void MediumGame()
    {
        SceneManager.LoadScene("Medium", LoadSceneMode.Single);
    }
    public void EasyGame()
    {
        SceneManager.LoadScene("Easy", LoadSceneMode.Single);
    }
}

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
        Debug.Log("quit");
    }
    public void MainScreen()
    {
        SceneManager.LoadScene("Main Menu");
        
    }

   public void GoodEnd()
    {
        SceneManager.LoadScene("GoodEnd");
        
    }
    public void BadEnd()
    {
        SceneManager.LoadScene("BadEnd");
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public string firstLevel;
    
    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string startLevel;

    public void LoadLevel()
    {
        SceneManager.LoadScene(startLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

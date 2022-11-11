using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public string levelToLoad;

    public void LoadLevel()
    {
        if (levelToLoad != "") SceneManager.LoadScene(levelToLoad);
        else Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{
    public void PlayGame(float scene)
        {
        if (scene == 1)
        {
            SceneManager.LoadScene(1);
        }
        if (scene == 2)
        {
            SceneManager.LoadScene(2);
        }
        if (scene == 3)
        {
            SceneManager.LoadScene(3);
        }

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch : MonoBehaviour
{
    public int scenecount = 1;

    public void LoadGameScene1()
    {
        SceneManager.LoadScene("Lvl1Stage1");
    }

    public void LoadGameScene2()
    {
        SceneManager.LoadScene("Lvl1Stage2");
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(scenecount);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OnTriggerEnter2D(Collider2D door)
    {
        if (door.CompareTag("Player"))
        {
            LoadNextScene();
        }
    }
}

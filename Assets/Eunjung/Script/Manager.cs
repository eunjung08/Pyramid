using Eunjung;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : Singleton<Manager>
{
    public bool isPause = false;
    public bool isLive = true;
    public Menu Menu;

    public enum GameStatus
    {
        None,
        Pause,
        Lobby,
        Stage,
        GameOver,
        Continue,
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPause)
            {
                PauseGame();
            }
            else
            {
                ContinueGame();
            }
        }
    }

    public void PauseGame()
    {
        //Time.timeScale = 0;
        //isPause = true;

        //Menu.SetMenu(Menu.MenuStatus.Pause);
    }

    public void ContinueGame()
    {
        //Time.timeScale = 1;
        //isPause = false;

        //Menu.SetMenu(Menu.MenuStatus.Continue);
    }

    public void RestartGame()
    {
        //SceneManager.LoadScene("Game");
        //isPause = false;
        //Time.timeScale = 1;
    }

    public void MainMenu()
    {
        //SceneManager.LoadScene("Main");
        //Time.timeScale = 1;
    }
}
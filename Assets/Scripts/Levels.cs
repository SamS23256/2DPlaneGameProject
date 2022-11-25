using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void LoadStartMenu()
    {
        //loads the intro menu
        SceneManager.LoadScene(0);
    }

    public void LoadStage1()
    {
        //loads the intro menu
        SceneManager.LoadScene("Stage1");
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOver()
    {
        //loads the intro menu
        SceneManager.LoadScene("GameOver");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

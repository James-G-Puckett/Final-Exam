using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void GoToHighScores()
    {
       
        SceneManager.LoadScene("2HighScores");
    }
    public void GoToGame()
    {
        SceneManager.LoadScene("3Game");
    }

    public void GoToExit()
    {
        SceneManager.LoadScene("4Exit");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}

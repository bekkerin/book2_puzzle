using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("chapter4");

    }
    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }
    public void ExitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
        SceneManager.LoadScene("Blank");

    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }
}

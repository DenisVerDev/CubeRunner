using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenue : MonoBehaviour
{
    public void StartRun()
    {
        SceneManager.LoadScene("PlaygroundScene");
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenue : MonoBehaviour
{
    public GameObject pauseMenue;

    public bool IsGamePaused 
    {
        get { return Time.timeScale == 0; } 
        set
        {
            Time.timeScale = value ? 0 : 1;
            pauseMenue.SetActive(value);
        }
    }

    void Start()
    {
        IsGamePaused = false; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) IsGamePaused = !IsGamePaused;
    }

    public void Restart() => SceneManager.LoadScene("PlaygroundScene");

    public void Leave() => SceneManager.LoadScene("MainMenueScene");
}

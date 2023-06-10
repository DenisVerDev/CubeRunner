using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameManager : MonoBehaviour
{
    public GameObject winingMenue;
    public PauseMenue pauseMenue;

    void Start()
    {
        FindObjectOfType<PlayerCollision>().PlayerDead += EndGameManager_PlayerDead;
        FindObjectOfType<StageManager>().Finished += EndGameManager_Finished;
    }

    private void EndGameManager_Finished(object sender, System.EventArgs e)
    {
        pauseMenue.IsGamePaused = true;
        winingMenue.SetActive(true);
    }

    private void EndGameManager_PlayerDead(object sender, System.EventArgs e)
    {
        pauseMenue.Invoke("Restart", 2);
    }
}

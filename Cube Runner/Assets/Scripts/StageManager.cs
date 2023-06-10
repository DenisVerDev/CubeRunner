using System;
using TMPro;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    //------FOR THE EDITOR---------
    public int maxStages; // maximum amount of stages
    public int baseScoreThreshold; // base number of the first score threshold(to reach second stage)

    public string animState;

    public TextMeshProUGUI stageText;

    public Animator stageAnimator;

    //------INSIDE VARIABLES---------
    public int CurrentStage { get; private set; }
    public int NextStageThreshold { get; private set; } // how much score needed to reach the next stage

    public event EventHandler NextStage;

    //-------METHODS------------------

    public void InitFirstStage()
    {
        NextStageThreshold = 0;
        SetStage(1);
        NextStage(null, null);
    }

    void Update()
    {
        if(CurrentStage < maxStages) // the last stage is the final one
        {
            if(RunManager.PlayerScore >= NextStageThreshold)
            {
                SetStage(CurrentStage + 1);
                UpdateUI();
                NextStage(null, null);
            }
        }
    }

    void SetStage(int stage)
    {
        CurrentStage = stage;
        NextStageThreshold += CurrentStage * baseScoreThreshold;
    }

    void UpdateUI()
    {
        // update ui
        string stage_suffix = CurrentStage switch
        {
            1 => "st",
            2 => "nd",
            3 => "rd",
            _ =>"th"
        };

        stageText.text = $"{CurrentStage}{stage_suffix} Stage";
        
        stageAnimator.enabled = true; // the first stage doesn't have an animation
        stageAnimator.Play(animState, -1, 0f);
    }
}

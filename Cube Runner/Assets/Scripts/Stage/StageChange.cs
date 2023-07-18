using UnityEngine;

public class StageChange : MonoBehaviour
{
    [SerializeField]
    private DynamicInt32SO currentStage;

    [SerializeField]
    private DynamicInt32SO scoreThreshold;

    [SerializeField]
    private DynamicVelocitySO runVelocity;

    [SerializeField]
    private DynamicFlagSO stageChangeEvent;

    [SerializeField]
    private DynamicFlagSO uiStageUpdateEvent;

    void Update()
    {
        if(stageChangeEvent.Value)
        {
            currentStage.Value++;
            scoreThreshold.Value += currentStage.Value * scoreThreshold.BaseValue;
            runVelocity.Value = currentStage.Value * runVelocity.BaseValue;

            uiStageUpdateEvent.Value = true;
            stageChangeEvent.Value = false;
        }
    }
}

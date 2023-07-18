using UnityEngine;

public class NextStage : MonoBehaviour
{
    [SerializeField]
    private DynamicInt32SO playerScore;

    [SerializeField]
    private DynamicInt32SO scoreThreshold;

    [SerializeField]
    private DynamicFlagSO stageChangeEvent;

    void Update()
    {
        if(playerScore.Value >= scoreThreshold.Value)
            stageChangeEvent.Value = true;
    }
}

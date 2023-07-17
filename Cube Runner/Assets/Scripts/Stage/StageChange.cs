using UnityEngine;

public class StageChange : MonoBehaviour
{
    [SerializeField]
    private Int32SO currentStage;

    [SerializeField]
    private Int32SO nextScoreThreshold;

    [SerializeField]
    private Int32SO baseScoreThreshold;

    [SerializeField]
    private VelocitySO currentRunVelocity;

    [SerializeField]
    private Int32SO baseRunVelocity;

    [SerializeField]
    private FlagSO stageChangeEvent;

#if UNITY_EDITOR
    void Start()
    {
        currentStage.value = 1;
        nextScoreThreshold.value = baseScoreThreshold.value;
        currentRunVelocity.Value = baseRunVelocity.value;
    }
#endif
    void Update()
    {
        if(stageChangeEvent.value)
        {
            currentStage.value++;
            nextScoreThreshold.value += currentStage.value * baseScoreThreshold.value;
            currentRunVelocity.Value = currentStage.value * baseRunVelocity.value;

            stageChangeEvent.value = false;
        }
    }
}

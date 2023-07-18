using UnityEngine;

public class NextStage : MonoBehaviour
{
    [SerializeField]
    private Int32SO playerScore;

    [SerializeField]
    private Int32SO nextScoreThreshold;

    [SerializeField]
    private FlagSO stageChangeEvent;

#if UNITY_EDITOR
    void Start() => stageChangeEvent.value = false;
#endif
    void Update()
    {
        if(playerScore.value >= nextScoreThreshold.value)
            stageChangeEvent.value = true;
    }
}

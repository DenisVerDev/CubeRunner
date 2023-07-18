using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField]
    private DynamicInt32SO playerScore;

    [SerializeField]
    private Int32SO rewardScore;

    [SerializeField]
    private DynamicFlagSO playerDeathEvent;

    [SerializeField]
    private DynamicFlagSO obstacleDeathEvent;

    [SerializeField]
    private DynamicFlagSO uiScoreUpdateEvent;

    void LateUpdate()
    {
        if (!playerDeathEvent.Value && obstacleDeathEvent.Value)
        {
            playerScore.Value += rewardScore.Value;

            uiScoreUpdateEvent.Value = true;
            obstacleDeathEvent.Value = false;
        }
    }
}

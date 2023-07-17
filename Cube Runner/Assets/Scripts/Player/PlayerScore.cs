using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField]
    private Int32SO playerScore;

    [SerializeField]
    private Int32SO rewardScore;

    [SerializeField]
    private FlagSO playerDeathEvent;

    [SerializeField]
    private FlagSO obstacleDeathEvent;

#if UNITY_EDITOR
    void Start() => playerScore.value = 0;
#endif
    void LateUpdate()
    {
        if (!playerDeathEvent.value && obstacleDeathEvent.value)
        {
            playerScore.value += rewardScore.value;
            obstacleDeathEvent.value = false;
        }
    }
}

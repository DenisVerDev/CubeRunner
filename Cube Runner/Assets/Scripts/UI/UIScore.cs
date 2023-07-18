using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField]
    private DynamicInt32SO playerScore;

    [SerializeField]
    private DynamicFlagSO uiScoreUpdateEvent;

    private TMP_Text scoreText;

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
    }

    void LateUpdate()
    {
        if(uiScoreUpdateEvent.Value)
        {
            scoreText.text = playerScore.Value.ToString();
            uiScoreUpdateEvent.Value = false;
        }
    }
}

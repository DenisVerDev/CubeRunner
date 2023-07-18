using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField]
    private Int32SO playerScore;

    [SerializeField]
    private FlagSO uiScoreUpdateEvent;

    private TMP_Text scoreText;

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        uiScoreUpdateEvent.value = true;
    }

    void LateUpdate()
    {
        if(uiScoreUpdateEvent.value)
        {
            scoreText.text = playerScore.value.ToString();
            uiScoreUpdateEvent.value = false;
        }
    }
}

using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int rewardPoints;

    public TextMeshProUGUI scoreText;

    public static int PlayerScore { get; set; }

    void Start()
    {
        PlayerScore = 0;
    }

    public void IncreaseScore()
    {
        PlayerScore += rewardPoints;
        scoreText.text = PlayerScore.ToString();
    }
}

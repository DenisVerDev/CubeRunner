using TMPro;
using UnityEngine;

public class RunManager : MonoBehaviour
{
    //------FOR THE EDITOR----
    public int rewardPoints;

    public float baseRunVelocity;

    public TextMeshProUGUI scoreText;

    //------VARIABLES----------
    public static int PlayerScore { get; set; }

    public float CurrentRunVelocity { get; set; }

    //-----SCRIPTS------
    private PlayerMovement playerMovement;
    private ObstacleManager obstacleManager;
    private StageManager stageManager;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        obstacleManager = FindObjectOfType<ObstacleManager>();
        stageManager = FindObjectOfType<StageManager>();

        stageManager.NextStage += StageManager_NextStage;
        stageManager.InitFirstStage();

        PlayerScore = 0;
    }

    void Update()
    {
        if (obstacleManager.CurrentObstacle == null)
        {
            // update score
            PlayerScore += rewardPoints;
            scoreText.text = PlayerScore.ToString();

            obstacleManager.SpawnObstacle(CurrentRunVelocity);
        }
    }

    private void StageManager_NextStage(object sender, System.EventArgs e)
    {
        CurrentRunVelocity = stageManager.CurrentStage * baseRunVelocity;
        playerMovement.PlayerVelocity = CurrentRunVelocity * 0.05f;
    }
}

using UnityEngine;

public class RunManager : MonoBehaviour
{
    public float baseRunVelocity;

    public float CurrentRunVelocity { get; set; }

    //-----SCRIPTS------
    private PlayerMovement playerMovement;
    private ObstacleManager obstacleManager;
    private StageManager stageManager;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        obstacleManager = FindObjectOfType<ObstacleManager>();
        stageManager = FindObjectOfType<StageManager>();
        scoreManager = FindObjectOfType<ScoreManager>();

        stageManager.NextStage += StageManager_NextStage;
        stageManager.InitFirstStage();

        obstacleManager.SpawnObstacle(CurrentRunVelocity); // to prevent score stonks at the begining
    }

    void Update()
    {
        if (obstacleManager.CurrentObstacle == null)
        {
            scoreManager.IncreaseScore();
            obstacleManager.SpawnObstacle(CurrentRunVelocity);
        }
    }

    private void StageManager_NextStage(object sender, System.EventArgs e)
    {
        CurrentRunVelocity = stageManager.CurrentStage * baseRunVelocity;
        playerMovement.PlayerVelocity = CurrentRunVelocity * 0.05f;
    }
}

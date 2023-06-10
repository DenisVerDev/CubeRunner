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

    private GameObject currentObstacle;

    //-----SCRIPTS------
    private ObstacleGeneration obstacleGeneration;
    private PlayerMovement playerMovement;
    private StageManager stageManager;

    // Start is called before the first frame update
    void Start()
    {
        obstacleGeneration = FindObjectOfType<ObstacleGeneration>();
        playerMovement = FindObjectOfType<PlayerMovement>();
        stageManager = FindObjectOfType<StageManager>();

        stageManager.NextStage += StageManager_NextStage;
        stageManager.InitFirstStage();

        PlayerScore = 0;

        currentObstacle = obstacleGeneration.SpawnObstacle(CurrentRunVelocity);
    }

    void Update()
    {
        if (currentObstacle == null)
        {
            // update score
            PlayerScore += rewardPoints;
            scoreText.text = PlayerScore.ToString();

            // spawn next obstacle
            currentObstacle = obstacleGeneration.SpawnObstacle(CurrentRunVelocity);
        }
    }

    private void StageManager_NextStage(object sender, System.EventArgs e)
    {
        CurrentRunVelocity = stageManager.CurrentStage * baseRunVelocity;
        playerMovement.PlayerVelocity = CurrentRunVelocity * 0.05f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle") Destroy(currentObstacle);
    }
}

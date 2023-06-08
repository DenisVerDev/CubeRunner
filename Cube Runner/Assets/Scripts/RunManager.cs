using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RunManager : MonoBehaviour
{
    public float runVelocity;

    private GameObject currentObstacle;

    private ObstacleGeneration obstacleGeneration;
    private PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        this.obstacleGeneration = FindObjectOfType<ObstacleGeneration>();
        this.playerMovement = FindObjectOfType<PlayerMovement>();

        this.playerMovement.PlayerVelocity = runVelocity*0.05f;

        this.currentObstacle = this.obstacleGeneration.SpawnObstacle(runVelocity);
    }

    void Update()
    {
        if (this.currentObstacle == null)
            this.currentObstacle = this.obstacleGeneration.SpawnObstacle(runVelocity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle") Destroy(this.currentObstacle);
    }
}

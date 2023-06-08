using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RunManager : MonoBehaviour
{
    public float runVelocity;

    private GenerateObstacles generateObstacles;

    private GameObject currentObstacle;

    // Start is called before the first frame update
    void Start()
    {
        this.generateObstacles = FindObjectOfType<GenerateObstacles>();
        this.SpawnObstacle();
    }

    void Update()
    {
        if (this.currentObstacle == null) this.SpawnObstacle();    
    }

    private void SpawnObstacle()
    {
        this.currentObstacle = this.generateObstacles.GenerateObstacle();

        var obstacles = FindObjectsOfType<ObstacleMovement>().ToList();
        obstacles.ForEach(x => x.ObstacleVelocity = runVelocity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle") Destroy(this.currentObstacle);
    }
}

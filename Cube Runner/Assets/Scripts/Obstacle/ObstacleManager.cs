using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public List<GameObject> prefab_obstacles;

    public GameObject CurrentObstacle { get; private set; }

    void Start()
    {
        FindObjectOfType<ObstacleTrash>().ObstacleReachedEnd += ObstacleManager_ObstacleReachedEnd;
    }

    public void SpawnObstacle(float velocity)
    {
        int rand_obstacle_index = Random.Range(0, prefab_obstacles.Count);
        CurrentObstacle = Instantiate(prefab_obstacles[rand_obstacle_index]);

        FindObjectsOfType<ObstacleMovement>()
            .ToList()
            .ForEach(x => x.ObstacleVelocity = velocity);
    }

    private void ObstacleManager_ObstacleReachedEnd(object sender, System.EventArgs e)
    {
        Destroy(CurrentObstacle);
    }
}

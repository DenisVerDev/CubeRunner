using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObstacleGeneration : MonoBehaviour
{
    public List<GameObject> prefab_obstacles;

    public GameObject SpawnObstacle(float velocity)
    {
        int rand_obstacle_index = Random.Range(0, prefab_obstacles.Count);
        GameObject obstacle = Instantiate(prefab_obstacles[rand_obstacle_index]);

        FindObjectsOfType<ObstacleMovement>()
            .ToList()
            .ForEach(x => x.ObstacleVelocity = velocity);

        return obstacle;
    }
}

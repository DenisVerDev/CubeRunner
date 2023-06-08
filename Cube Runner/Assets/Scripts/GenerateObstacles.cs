using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    public List<GameObject> prefab_obstacles;

    public GameObject GenerateObstacle()
    {
        int rand_obstacle_index = Random.Range(0, prefab_obstacles.Count);
        return Instantiate(prefab_obstacles[rand_obstacle_index]);
    }
}

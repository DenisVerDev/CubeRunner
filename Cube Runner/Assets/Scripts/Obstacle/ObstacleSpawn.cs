using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObjectListSO prefabObstacles;

    [SerializeField]
    private GameObjectSO currentObstacle;

    private void Start() => currentObstacle.gameObject = null;

    void Update()
    {
        if(currentObstacle.gameObject == null)
        {
            int rand_obstacle_index = Random.Range(0, prefabObstacles.list.Count);
            currentObstacle.gameObject = Instantiate(prefabObstacles.list[rand_obstacle_index]);
        }
    }
}

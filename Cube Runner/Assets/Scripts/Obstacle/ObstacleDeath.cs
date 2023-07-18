using UnityEngine;

public class ObstacleDeath : MonoBehaviour
{
    [SerializeField]
    private GameObjectSO currentObstacle;

    [SerializeField]
    private TagSO obstacleTag;

    [SerializeField]
    private DynamicFlagSO obstacleDeathEvent;

    [SerializeField]
    private DynamicFlagSO playerDeathEvent;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(obstacleTag.tag) && !playerDeathEvent.Value)
        {
            Destroy(currentObstacle.gameObject);
            obstacleDeathEvent.Value = true;
        }
    }
}

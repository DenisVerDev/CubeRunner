using UnityEngine;

public class ObstacleDeath : MonoBehaviour
{
    [SerializeField]
    private GameObjectSO currentObstacle;

    [SerializeField]
    private TagSO obstacleTag;

    [SerializeField]
    private FlagSO obstacleDeathEvent;

    [SerializeField]
    private FlagSO playerDeathEvent;

#if UNITY_EDITOR
    private void Start() => obstacleDeathEvent.value = false;
#endif
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(obstacleTag.tag) && !playerDeathEvent.value)
        {
            Destroy(currentObstacle.gameObject);
            obstacleDeathEvent.value = true;
        }
    }
}

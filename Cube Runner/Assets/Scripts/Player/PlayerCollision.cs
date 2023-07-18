using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    private TagSO obstacleTag;

    [SerializeField]
    private DynamicFlagSO playerDeathEvent;

    private void FixedUpdate()
    {
        if (transform.position.y < -1f)
            playerDeathEvent.Value = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(obstacleTag.tag))
            playerDeathEvent.Value = true;
    }
}

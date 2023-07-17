using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    private TagSO obstacleTag;

    [SerializeField]
    private FlagSO playerDeathEvent;

    private void FixedUpdate()
    {
        if (transform.position.y < -1f)
            playerDeathEvent.value = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(obstacleTag.tag))
            playerDeathEvent.value = true;
    }
}

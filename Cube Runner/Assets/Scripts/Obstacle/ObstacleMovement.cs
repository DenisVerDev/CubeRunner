using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField]
    private VelocitySO currentRunVelocity;

    private new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, -currentRunVelocity.Value, ForceMode.Force);
    }
}

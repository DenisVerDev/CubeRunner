using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField]
    private DynamicVelocitySO runVelocity;

    private new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, -runVelocity.Value, ForceMode.Force);
    }
}

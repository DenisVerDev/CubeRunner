using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveCoefficient;

    [SerializeField]
    private VelocitySO currentRunVelocity;

    private new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) rigidbody.AddForce(-currentRunVelocity.Value * moveCoefficient, 0, 0, ForceMode.VelocityChange);
        else if (Input.GetKey(KeyCode.D)) rigidbody.AddForce(currentRunVelocity.Value * moveCoefficient, 0, 0, ForceMode.VelocityChange);
    }
}

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveCoefficient;

    [SerializeField]
    private DynamicVelocitySO runVelocity;

    private new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) rigidbody.AddForce(-runVelocity.Value * moveCoefficient, 0, 0, ForceMode.VelocityChange);
        else if (Input.GetKey(KeyCode.D)) rigidbody.AddForce(runVelocity.Value * moveCoefficient, 0, 0, ForceMode.VelocityChange);
    }
}

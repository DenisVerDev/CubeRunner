using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float ObstacleVelocity 
    {
        get { return velocity * Time.deltaTime; }
        set
        {
            velocity = value <= 0 ? 10 : value;
        }
    }

    private float velocity;

    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = (Rigidbody)GetComponent(typeof(Rigidbody));
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, -ObstacleVelocity, ForceMode.VelocityChange);
    }
}

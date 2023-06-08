using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody obstacleRigidbody;

    public float ObstacleVelocity 
    {
        get { return velocity * Time.deltaTime; }
        set
        {
            velocity = value < 0 ? 1000 : value;
        }
    }

    private float velocity;

    void FixedUpdate()
    {
        obstacleRigidbody.AddForce(0, 0, -ObstacleVelocity, ForceMode.Force);
    }
}

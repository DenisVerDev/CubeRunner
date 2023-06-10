using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRigidbody;

    public float PlayerVelocity 
    {
        get { return playerVelocity * Time.deltaTime; } 
        set
        {
            playerVelocity = value < 0 ? 0 : value;
        }
    }

    private float playerVelocity;

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A)) playerRigidbody.AddForce(-PlayerVelocity, 0, 0, ForceMode.VelocityChange);
        else if (Input.GetKey(KeyCode.D)) playerRigidbody.AddForce(PlayerVelocity, 0, 0, ForceMode.VelocityChange);
    }
}

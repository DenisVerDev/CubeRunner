using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<ObstacleMovement>().enabled = false;
            FindObjectOfType<PlayerMovement>().enabled = false;
        }
    }
}

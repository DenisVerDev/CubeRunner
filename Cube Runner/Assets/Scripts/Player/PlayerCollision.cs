using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public event EventHandler PlayerDead;

    void FixedUpdate()
    {
        if (transform.position.y < -1f)
            PlayerDead(null, null);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
            PlayerDead(null, null);
    }
}

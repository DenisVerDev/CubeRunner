using System;
using UnityEngine;

public class ObstacleTrash : MonoBehaviour
{
    public event EventHandler ObstacleReachedEnd;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle") ObstacleReachedEnd(null, null);
    }
}

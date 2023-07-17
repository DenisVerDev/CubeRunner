using UnityEngine;

public class CameraBinding : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform;

    [SerializeField]
    private Vector3 cameraOffset;

    void LateUpdate()
    {
        transform.position = playerTransform.position + cameraOffset;
    }
}

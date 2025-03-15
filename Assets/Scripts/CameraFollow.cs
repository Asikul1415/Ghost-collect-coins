using Sample;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform ghostTransform;
    private float SmoothSpeed = 0.05f;
    void Start()
    {
        ghostTransform = FindAnyObjectByType<GhostScript>().transform;
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(ghostTransform.position.x, transform.position.y, ghostTransform.position.z), SmoothSpeed);
    }
}

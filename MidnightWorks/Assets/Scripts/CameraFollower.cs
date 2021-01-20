using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;

    private Vector3 velocity;

    private void LateUpdate()
    {
        Vector3 targetPosition = target.transform.position + offset;
        targetPosition.x = 0;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime * Time.deltaTime);
    }
}

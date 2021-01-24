using UnityEngine;

public class TargetFollower : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    [SerializeField] private bool freezX;

    private Vector3 velocity;

    private void FixedUpdate()
    {
        if (GameStateManager.CurrentState == GameState.Game)
        {

            Vector3 targetPosition = target.transform.position + offset;
            if (freezX)
            {
                targetPosition.x = 0;
            }

            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime * Time.fixedDeltaTime);
        }
    }
}

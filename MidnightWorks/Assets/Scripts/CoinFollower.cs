using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFollower : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;


    public void ChangeTarget(Transform transform)
    {
        target = transform;
    }


    private Vector3 velocity;

    private void FixedUpdate()
    {
        if (GameStateManager.CurrentState == GameState.Game)
        {
            Vector3 targetPosition = target.transform.position + offset;
            targetPosition.x = 0;

            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime * Time.fixedDeltaTime);
        }
    }


}

using System;
using UnityEngine;
using DG.Tweening;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1;
    [SerializeField] private float floatingSpeed = 1;
    [SerializeField] private float floatingRange = 1;
    [SerializeField] private float groundDistance = 0.1f;
    [SerializeField] private float offset = 0.1f;
    [SerializeField] private bool isPlayer = false;

    private void Awake()
    {
        GameStateManager.OnGameStateChange += Animation;
    }

    private void OnDestroy()
    {
        GameStateManager.OnGameStateChange -= Animation;

    }

    private void Animation(GameState state)
    {
        if (state == GameState.Lose)
        {
            if (isPlayer)
            {
                 transform.DORotate(Vector3.right * 90, 0.4f).SetEase(Ease.OutBounce);
                 transform.DOLocalMove(Vector3.up * 0.1f , 0.4f).SetEase(Ease.OutBounce);
            }
        }
    }

    void Update()
    {
        if (GameStateManager.CurrentState == GameState.Lose && isPlayer) 
        {
            return;
        }

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.localPosition = new Vector3(transform.localPosition.x,
            Mathf.Sin((Time.time+ offset) * floatingSpeed) * floatingRange + floatingRange + groundDistance,
            transform.localPosition.z);
    }
}

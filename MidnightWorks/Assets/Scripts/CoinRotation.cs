using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1;
    [SerializeField] private float floatingSpeed = 1;
    [SerializeField] private float floatingRange = 1;
    [SerializeField] private float groundDistance = 0.1f;


    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.localPosition = new Vector3(0, Mathf.Sin(Time.time * floatingSpeed) * floatingRange + floatingRange + groundDistance, 0);
    }
}

using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private float speed;


    private void Update()
    {
        transform.localPosition = new Vector3(Mathf.Sin(Time.time * speed) * range, 0, 0);
    }
}

using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private float smoothTime;
    [SerializeField] private float leftRightMaxPosition;
    [SerializeField] private float movingSpeed;

    private Vector3 velocity;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movingSpeed);

        if (Input.GetMouseButton(0))
        {
            float inputP = Input.mousePosition.x / Screen.width * 2 - 1;
            Vector3 targetPosition = new Vector3(inputP * leftRightMaxPosition, transform.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime * Time.deltaTime);
        }
    }
}

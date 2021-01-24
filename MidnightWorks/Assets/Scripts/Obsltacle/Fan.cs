using UnityEngine;

public class Fan : MonoBehaviour
{
    [SerializeField] private float speed = 10; 


    void Update()
    {
        if (GameStateManager.CurrentState == GameState.Game)
        {
            transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        }
    }
}

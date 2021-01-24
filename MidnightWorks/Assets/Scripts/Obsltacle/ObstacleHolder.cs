using UnityEngine;

public class ObstacleHolder : MonoBehaviour
{
    private Obstacle[] obstacles;
    private bool isUsing;
    public bool IsUsing => isUsing;

    private void Awake()
    {
        obstacles = GetComponentsInChildren<Obstacle>(true);
    }

    public void EnableObstacles()
    {
        isUsing = true;
        foreach (var obstacle in obstacles)
        {
            obstacle.gameObject.SetActive(true);
        }
    }

    public void DisableObstacles()
    {
        isUsing = false;
        foreach (var obstacle in obstacles)
        {
            obstacle.gameObject.SetActive(false);
        }
    }
}


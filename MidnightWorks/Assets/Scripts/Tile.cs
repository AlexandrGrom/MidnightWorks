using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private float lenght;
    private ObstacleHolder ObstacleHolder;

    public float Lenght => lenght;

    public void GetPattern()
    {
        ObstacleHolder = ObstacleManager.PlaceObstacle(transform);
        ObstacleHolder.EnableObstacles();
    }
    public void DisableObstacles()
    {
        ObstacleHolder?.DisableObstacles();
    }
}

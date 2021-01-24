﻿using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private float lenght;

    private ObstacleHolder obstacleHolder;
    private CoinHolder coinHolder;

    public float Lenght => lenght;


    public void GetPattern(int i)
    {
        if (i % 2 == 1)
        {
            obstacleHolder = ObstacleManager.PlaceObstacle(transform);
            obstacleHolder.EnableObstacles();
        }
        else
        {
            obstacleHolder?.DisableObstacles();
        }

        if (i % 2 == 0)
        {
            coinHolder = CoinManager.PlaceCoin(transform);
            coinHolder.EnableCoins();
        }
        else
        {
            coinHolder?.DisableCoins();
        }
    }
}

using System;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    private ObstacleHolder[] obstacles;
	public static Func<Transform,ObstacleHolder> PlaceObstacle;

	private void Awake()
	{
		obstacles = GetComponentsInChildren<ObstacleHolder>();
		PlaceObstacle += SetObstacle;
	}

	private void OnDestroy()
	{
		PlaceObstacle -= SetObstacle;
	}

	private ObstacleHolder SetObstacle(Transform parent)
	{
		ObstacleHolder holder = obstacles[UnityEngine.Random.Range(0, obstacles.Length)];

		while (holder.IsUsing)
        {
			holder = obstacles[UnityEngine.Random.Range(0, obstacles.Length)];
        }
		holder.transform.SetParent(parent);
		holder.transform.localPosition = Vector3.zero;
		return holder;
	}


}

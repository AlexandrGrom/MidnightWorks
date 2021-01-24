using System;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

	private CoinHolder[] coins;
	public static Func<Transform, CoinHolder> PlaceCoin;

	private void Awake()
	{
		coins = GetComponentsInChildren<CoinHolder>();
		PlaceCoin += SetCoin;
	}

	private void OnDestroy()
	{
		PlaceCoin -= SetCoin;
	}

	private CoinHolder SetCoin(Transform parent)
	{
		CoinHolder holder = coins[UnityEngine.Random.Range(0, coins.Length)];

		while (holder.IsUsing)
		{
			holder = coins[UnityEngine.Random.Range(0, coins.Length)];
		}
		holder.transform.SetParent(parent);
		holder.transform.localPosition = Vector3.zero;
		return holder;
	}


}

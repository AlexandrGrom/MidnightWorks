using UnityEngine;

public class CoinHolder : MonoBehaviour
{
    private Coins[] obstacles;
    private bool isUsing;
    public bool IsUsing => isUsing;

    private void Awake()
    {
        obstacles = GetComponentsInChildren<Coins>(true);
    }

    public void EnableCoins()
    {
        isUsing = true;
        foreach (var obstacle in obstacles)
        {
            obstacle.gameObject.SetActive(true);
        }
    }

    public void DisableCoins()
    {
        isUsing = false;
        foreach (var obstacle in obstacles)
        {
            obstacle.gameObject.SetActive(false);
        }
    }
}


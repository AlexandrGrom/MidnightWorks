using UnityEngine;
using DG.Tweening;

public class LifeControllre : MonoBehaviour
{
    [SerializeField] private Transform[] lifes;
    private int lifesAmount =0;


    private void Awake()
    {
        foreach (var life in lifes)
        {
            life.localScale = Vector3.zero;
        }
    }
    public void TakeDamage()
    {
        if (lifesAmount-1 < 0)
        {
            GameStateManager.CurrentState = GameState.Lose;
            return;
        }
        lifes[lifesAmount - 1].DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack);
        lifesAmount --;

    }

    public void PickLife()
    {
        if (lifesAmount > lifes.Length-1)
        {
            return;
        }
        lifes[lifesAmount].DOScale(Vector3.one, 0.2f).SetEase(Ease.OutBack);
        lifesAmount++;
        
    }

}

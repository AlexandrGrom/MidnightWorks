using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;


public class MainMenu : ScreenElement
{
    [SerializeField] private EventTrigger startGame;
    [SerializeField] private TextMeshProUGUI bestScore;

    private void Awake()
    {

        bestScore.text = ScoreManager.bestScore.ToString();

        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;

        entry.callback.AddListener((data) => GameStateManager.CurrentState = GameState.Game);
        startGame.triggers.Add(entry);
    }

    private void OnEnable()
    {
        startGame.transform.localScale = Vector3.up;
        startGame.transform.DOScale(Vector3.one, 0.2f).SetEase(Ease.OutBack);
    }
}

using UnityEngine;
using UnityEngine.EventSystems;

public class MainMenu : ScreenElement
{
    [SerializeField] private EventTrigger startGame;

    private void Awake()
    {
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;

        entry.callback.AddListener((data) => GameStateManager.CurrentState = GameState.Game);
        startGame.triggers.Add(entry);
    }
}

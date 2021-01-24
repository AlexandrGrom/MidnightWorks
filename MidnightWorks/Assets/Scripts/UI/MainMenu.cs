using UnityEngine;
using UnityEngine.UI;

public class MainMenu : ScreenElement
{
    [SerializeField] private Button startGame;

    private void Awake()
    {
        startGame.onClick.AddListener(()=>GameStateManager.CurrentState = GameState.Game);
    }
}

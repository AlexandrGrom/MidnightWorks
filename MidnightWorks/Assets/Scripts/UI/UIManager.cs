using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    private Dictionary<GameState, ScreenElement> screenElements;


    private void Awake()
    {
        screenElements = GetComponentsInChildren<ScreenElement>(true).ToDictionary(x => x.State, x => x);

        GameStateManager.OnGameStateChange += OnChangeState;
        GameStateManager.CurrentState = GameState.Menu;
    }

    private void OnDestroy()
    {
        GameStateManager.OnGameStateChange -= OnChangeState;
    }

    private void OnChangeState(GameState state)
    {
        foreach (var screen in screenElements)
        {
            screen.Value.gameObject.SetActive(false);
        }
        screenElements[state].gameObject.SetActive(true);
    }

    public static bool IsPointerOverUI()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
}

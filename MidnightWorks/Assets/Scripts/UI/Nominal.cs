using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Nominal : MonoBehaviour
{
    private TextMeshPro text;
    private void Awake()
    {
        text = GetComponent<TextMeshPro>();
        GameStateManager.OnGameStateChange += ChangeBehaviour;

    }
    private void OnDestroy()
    {
        GameStateManager.OnGameStateChange -= ChangeBehaviour;
    }

    private void ChangeBehaviour(GameState obj)
    {
        switch (obj)
        {
            case GameState.Menu:
                text.text = "Coin Run";
                break;
            case GameState.Game:
                StartCoroutine(nameof(UpdateText));
                break;
            case GameState.Lose:
                text.text = "Rip";
                StopCoroutine(nameof(UpdateText));
                break;
        }
    }

    private IEnumerator UpdateText()
    {
        while (true)
        {
            text.text = ScoreManager.CurrentScore.ToString();
            yield return null;
        }
    }
}

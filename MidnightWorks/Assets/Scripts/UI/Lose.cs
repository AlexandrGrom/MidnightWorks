using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;


public class Lose : ScreenElement
{
    [SerializeField] private Button bestScore;
    [SerializeField] private TextMeshProUGUI score;


    private void Awake()
    {
        bestScore.onClick.AddListener(() => SceneManager.LoadScene(0));
    }

    private void OnEnable()
    {
        score.text = ScoreManager.CurrentScore.ToString();
        score.transform.localScale = Vector3.up;
        bestScore.transform.localScale = Vector3.up;
        score.transform.DOScale(Vector3.one, 0.2f).SetEase(Ease.OutBack).OnComplete(()=> bestScore.transform.DOScale(Vector3.one,0.2f).SetEase(Ease.OutBack));
    }
}


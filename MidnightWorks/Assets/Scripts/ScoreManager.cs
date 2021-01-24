using UnityEngine;

public static class ScoreManager
{
    private const string best = "Best";
    static public int bestScore => PlayerPrefs.GetInt(best);

    static private int currentScore;
    static public int CurrentScore
    {
        get { return currentScore; }
        set
        {
            currentScore = value;
            if (value > bestScore)
            {
                PlayerPrefs.SetInt(best, value);
            }
        }
    }
   

}

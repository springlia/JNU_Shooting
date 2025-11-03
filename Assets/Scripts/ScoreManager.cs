using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI currentScoreUI;
    public int currentScore;

    public TextMeshProUGUI bestScoreUI;
    public int bestScore;

    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score");
        bestScoreUI.text = "best" + bestScore.ToString();
    }
    private void Update()
    {
        currentScoreUI.text = currentScore.ToString();
    }

    public void SetScore(int value)
    {
        currentScore = value;
        currentScoreUI.text = "best : " + bestScore.ToString();
        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreUI.text = "best : " + bestScore.ToString();
            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }
    public int GetScore()
    {
        return currentScore;
    }
}

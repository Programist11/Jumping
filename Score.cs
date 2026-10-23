using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0, bestScore = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;
    public static Score instance;
    private void Awake()
    {
        instance = this;
        if (PlayerPrefs.HasKey("SaveScore"))
        {
            bestScore = PlayerPrefs.GetInt("SaveScore");
        }
    }
    private void Update()
    {
        scoreText.text = "Score: " + score;
        bestScoreText.text = "Best score: " + bestScore;
    }
    public void AddScore()
    {
        score++;
        AddBestScore();
    }
    public void AddBestScore()
    {
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("SaveScore", bestScore);
        }
    }
    public void ResetScore()
    {
        score = 0;
    }
    public void ResetBestScore()
    {
        PlayerPrefs.DeleteKey("SaveScore");
        bestScore = 0;
    }
}

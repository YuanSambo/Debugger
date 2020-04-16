using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public FloatVariable scoreData;
    public bool ResetScore;
    private TextMeshProUGUI ScoreText;

    void Start()
    {
        ScoreText = GetComponent<TextMeshProUGUI>();
        if (ResetScore)
        {
            scoreData.initialValue = 0;
        }

    }

    private void Update()
    {
        ScoreText.text = $"Score : {scoreData.initialValue}";
        if (scoreData.initialValue > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", (int)scoreData.initialValue);
        }

    }
    public void Score(EnemyData enemy)
    {
        scoreData.initialValue += enemy.Points;
    }
}

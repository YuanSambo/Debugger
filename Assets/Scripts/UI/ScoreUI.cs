using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public FloatVariable scoreData;
    public bool ResetScore;
    private Text ScoreText;

    void Start()
    {
        ScoreText = GetComponent<Text>();
        if (ResetScore)
        {
            scoreData.initialValue = 0;
        }

    }

    private void Update()
    {
        ScoreText.text = $"Score : {scoreData.initialValue}";

    }
    public void Score(EnemyData enemy)
    {
        scoreData.initialValue += enemy.Points;
    }
}

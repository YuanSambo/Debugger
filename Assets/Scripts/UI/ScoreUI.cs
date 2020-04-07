using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    private int score = 0;
    private Text ScoreText;

    void Start()
    {
        ScoreText = GetComponent<Text>();
    }


    public void Score(EnemyData enemy)
    {
        score+=enemy.Points;
        ScoreText.text = $"Score : {score}";
    }
}

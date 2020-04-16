using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreUI : MonoBehaviour
{
    private TextMeshProUGUI HighScoreText;


    void Start()
    {
        HighScoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        HighScoreText.text = $"HighScore : {PlayerPrefs.GetInt("HighScore")}";
    }
}

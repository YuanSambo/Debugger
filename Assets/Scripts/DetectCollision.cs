using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    public static int score = 0;
    GameObject Score;
    Text ScoreText;


    private void Start()
    {
        Score = GameObject.Find("Score");
        ScoreText = Score.GetComponent<Text>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Projectile"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            score++;
            ScoreText.text = $"Score : {score}";

        }



    }
}

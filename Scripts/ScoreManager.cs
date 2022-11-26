using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    float Timer = 0;

    int score = 0;
    int highscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Score:" + score.ToString();
        highscoreText.text = "Hightscore:" + highscore.ToString();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AddPoint();
    }

    void AddPoint() {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            score +=1;
            scoreText.text = "Score:" + score.ToString();
            if(highscore < score)
            {
                PlayerPrefs.SetInt("highscore", score);
            }
            Timer = 1f;
        }
    }
}

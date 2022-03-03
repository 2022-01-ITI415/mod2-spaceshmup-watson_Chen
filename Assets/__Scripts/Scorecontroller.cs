using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorecontroller : MonoBehaviour
{
    public static Scorecontroller instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore ", 0);
        scoreText.text = score.ToString() + " points";  
        highscoreText.text = "Highscore: " + highscore.ToString();
        instance = this;
    }

    public void AddPoint() {
        score += 100;
        scoreText.text = score.ToString() + " Points"; 
        if (highscore < score)
        PlayerPrefs.SetInt("highscore ", score);
    }
}

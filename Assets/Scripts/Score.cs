using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public float startScore;
    public float scoreIncrease;

    // Start is called before the first frame update
    void Start()
    {
        //startScore = Time.time;
        startScore = 0f;
        scoreIncrease = 1f;
        highscoreText.text = "Highscore: " + ((int)PlayerPrefs.GetFloat("HighScore")).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //float t = Time.time - startScore;
        //string seconds = ((int)t % 60).ToString();
        scoreText.text = "Score:" + (int)startScore;
        startScore += scoreIncrease * Time.deltaTime;
        if (PlayerPrefs.GetInt("HighScore") < startScore)
            PlayerPrefs.SetFloat("HighScore", startScore);
    }
}

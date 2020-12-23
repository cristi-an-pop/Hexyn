using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
    public static bool isLoading = false;
    public Text highscoreText;

    void Start()
    {
        //(int)PlayerPrefs.GetInt("HighScore") = data.highscore;

        highscoreText.text = "HIGHSCORE\n" + ((int)PlayerPrefs.GetFloat("HighScore")).ToString();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        isLoading = true;
    }
}

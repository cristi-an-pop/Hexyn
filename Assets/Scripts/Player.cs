using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using System;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public static float movement = 0f;
    public static bool p_movement;

    public float scoreAmount;
    public float scoreIncrease;

    public Text scoreText;
    public Text highscoreText;

    public float slowDownFactor = 10f;
    public float slowMotionTime = 1f;

    public bool nextIncrease = false;

    public AudioSource death_sound;
    public AudioSource background_sound;

    public GameObject death_panel;

    public static int lives = 1;

    public static int HighScoreCount;

    private void Awake()
    {
        HighScoreCount = (int)PlayerPrefs.GetFloat("HighScore");
    }

    void Start()
    {
        p_movement = true;

        if(PlayerPrefsX.GetBool("soundsMODE") == false)
        {
            background_sound.mute = !background_sound.mute;
            death_sound.mute = !death_sound.mute;
        }
        else
        {
            background_sound.mute = background_sound.mute;
            death_sound.mute = death_sound.mute;
        }
            
        Time.timeScale = 1f;
        movement = 0f;
        scoreAmount = 0f;
        scoreIncrease = 1f;
        highscoreText.text = "HIGHSCORE: " + HighScoreCount.ToString();

        death_sound = GetComponent<AudioSource>();
        background_sound.time = 1.5f;
    }
    void Update()
    {
        //SCORE SYSTEM
        if ((int)scoreAmount >= 10 && (int)scoreAmount % 10 == 0)
        {
            if(nextIncrease == false)
            {
                nextIncrease = true;
                StartCoroutine(RotationSpeed());
            }
        }
        scoreText.text = "SCORE:" + (int)scoreAmount;
        scoreAmount += scoreIncrease * Time.deltaTime;

        //MOVEMENT SYSTEM
        if(p_movement == true)
        {
            if (Input.touchCount > 0)
            {
                Touch t = Input.GetTouch(0);
                if (t.position.x > Screen.width / 2)
                {
                    movement = 1;
                }
                else
                {
                    movement = -1;
                }
                transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
            }
        }
        

        if (MainScene_Button.ResumeMusic == true)
            background_sound.UnPause();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        p_movement = false;

        background_sound.Pause();
        death_sound.Play();
        MainScene_Button.ResumeMusic = false;

        if (PlayerPrefs.GetFloat("HighScore") < scoreAmount)
            PlayerPrefs.SetFloat("HighScore", scoreAmount);
        
        StartCoroutine(SlowDownAndStop());
    }
    IEnumerator RotationSpeed()
    {
        Rotator.rotationSpeed += 5f;
        if(Spawner.spawnRate <= 2f)
        {
            Spawner.spawnRate += 0.1f;
        }
        if(Hexagon.shrinkSpeed <= 4f && Hexagon2.shrinkSpeed <= 4f)
        {
            Hexagon.shrinkSpeed += 0.1f;
            Hexagon2.shrinkSpeed += 0.1f;
        }
        yield return new WaitForSeconds(10);
        nextIncrease = false;
    }

    private IEnumerator SlowDownAndStop()
    {
        //inainte 1 secunda
        Time.timeScale = 1 / slowDownFactor;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowDownFactor;

        yield return new WaitForSeconds(slowMotionTime / slowDownFactor);

        death_panel.SetActive(true);

        //dupa 1 secunda
        Time.timeScale = 0f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDownFactor;
        SaveSystem.SavePlayer(this);
    }
}

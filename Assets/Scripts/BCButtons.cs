using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BCButtons : MonoBehaviour
{
    /*
     *##############################################################*
                            Background Colors
     *##############################################################*
    */
    public static int EpilepticAttack = 0;

    string htmlRed = "#cc0000";
    string htmlPurple = "#9400D3";
    string htmlBlue = "#0000b3";
    string htmlGray = "#A9A9A9";
    string htmlGreen = "#32CD32";
    string htmlCyan = "#00CED1";
    string htmlYellow = "#FFDC00";

    public Color red_color;
    public Color blue_color;
    public Color gray_color;
    public Color green_color;
    public Color cyan_color;
    public Color purple_color;
    public Color yellow_color;

    public GameObject fake_blue;
    public GameObject fake_green;
    public GameObject fake_yellow;
    public GameObject fake_multi;

    public static int ads_watched = 0;

    void Awake()
    {
        //HTML TO RGB CONVERTIONS
        ColorUtility.TryParseHtmlString(htmlRed, out red_color);
        ColorUtility.TryParseHtmlString(htmlPurple, out purple_color);
        ColorUtility.TryParseHtmlString(htmlBlue, out blue_color);
        ColorUtility.TryParseHtmlString(htmlGray, out gray_color);
        ColorUtility.TryParseHtmlString(htmlGreen, out green_color);
        ColorUtility.TryParseHtmlString(htmlCyan, out cyan_color);
        ColorUtility.TryParseHtmlString(htmlYellow, out yellow_color);
        
        //BUTTONS
        ads_watched = PlayerPrefs.GetInt("adsWatched");
        if ((int)PlayerPrefs.GetFloat("HighScore") >= 50)
            fake_blue.SetActive(false);
        if ((int)PlayerPrefs.GetFloat("HighScore") >= 50)
            fake_green.SetActive(false);
        if ((int)PlayerPrefs.GetFloat("HighScore") >= 50)
            fake_yellow.SetActive(false);
        if (PlayerPrefs.GetInt("adsWatched") >= 5)
            fake_multi.SetActive(false);
            
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("adsWatched") >= 5)
            fake_multi.SetActive(false);
    }

    public void RedButton()
    {
        ColorS.defaultColor = red_color;
        PlayerPrefsX.SetColor("BackgroundColor", red_color);
        EpilepticAttack = 0;
    }

    public void BlueButton()
    {
        ColorS.defaultColor = blue_color;
        PlayerPrefsX.SetColor("BackgroundColor", blue_color);
        EpilepticAttack = 0;
    }

    public void GrayButton()
    {
        ColorS.defaultColor = gray_color;
        PlayerPrefsX.SetColor("BackgroundColor", gray_color);
        EpilepticAttack = 0;
    }

    public void GreenButton()
    {
        ColorS.defaultColor = green_color;
        PlayerPrefsX.SetColor("BackgroundColor", green_color);
        EpilepticAttack = 0;
    }

    public void CyanButton()
    {
        ColorS.defaultColor = cyan_color;
        PlayerPrefsX.SetColor("BackgroundColor", cyan_color);
        EpilepticAttack = 0;
    }

    public void PurpleButton()
    {
        ColorS.defaultColor = purple_color;
        PlayerPrefsX.SetColor("BackgroundColor", purple_color);
        EpilepticAttack = 0;
    }

    public void YellowButton()
    {
        ColorS.defaultColor = yellow_color;
        PlayerPrefsX.SetColor("BackgroundColor", yellow_color);
        EpilepticAttack = 0;
    }

    public void MultiLerp()
    {
        EpilepticAttack = 1;
        PlayerPrefs.SetInt("EpilepticAttack", EpilepticAttack);
    }
}

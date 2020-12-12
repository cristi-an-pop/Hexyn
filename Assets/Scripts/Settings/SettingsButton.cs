using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    public GameObject button_MusicON;
    public GameObject button_MusicOFF;

    public static bool soundsMODE = true;

    private void Awake()
    {
        if(PlayerPrefsX.GetBool("soundsMODE") == true)
        {
            button_MusicOFF.SetActive(false);
            button_MusicON.SetActive(true);
        }    
        else
        {
            button_MusicOFF.SetActive(true);
            button_MusicON.SetActive(false);
        }
    }

    public void TurnMusicOFF()
    {
        soundsMODE = false;
        PlayerPrefsX.SetBool("soundsMODE", false);

        button_MusicON.SetActive(false);
        button_MusicOFF.SetActive(true);
    }

    public void TurnMusicON()
    {
        soundsMODE = true;
        PlayerPrefsX.SetBool("soundsMODE", true);

        button_MusicON.SetActive(true);
        button_MusicOFF.SetActive(false);
    }
}

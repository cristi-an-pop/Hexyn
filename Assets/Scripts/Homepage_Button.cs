using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Homepage_Button : MonoBehaviour
{
    public GameObject homepageButton;

    public void ClickTheButton()
    {
        SceneManager.LoadScene(0);
        Button b = GetComponent<Button>();
        AudioSource audio = GetComponent<AudioSource>();
        b.onClick.AddListener(delegate () { audio.Play(); });

    }
}

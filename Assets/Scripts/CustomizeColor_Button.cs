using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustomizeColor_Button : MonoBehaviour
{
    public GameObject customizeButton;

    public void ClickTheButton()
    {
        SceneManager.LoadScene(2);
        Button b = GetComponent<Button>();
        AudioSource audio = GetComponent<AudioSource>();
        b.onClick.AddListener(delegate () { audio.Play(); });
    }
}

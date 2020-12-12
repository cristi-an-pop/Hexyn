using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeScene_Buttons : MonoBehaviour
{
    public GameObject BColorsPanel;
    public GameObject PSelectorPanel;

    public void BackgroundColors_Button()
    {
        BColorsPanel.SetActive(true);
        PSelectorPanel.SetActive(false);
    }

    public void PlayerSelector_Button()
    {
        PSelectorPanel.SetActive(true);
        BColorsPanel.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerButton : MonoBehaviour
{
    public GameObject ColorPickerI;
    public GameObject ColorPickerF;
    private int i = 0;
    private int f = 0;
    public void ClickTheButtonI()
    {
        i += 1;
        if (i % 2 != 0)
            ColorPickerI.SetActive(true);
        else
            ColorPickerI.SetActive(false);
    }

    public void ClickTheButtonF()
    {
        f += 1;
        if (f % 2 != 0)
            ColorPickerF.SetActive(true);
        else
            ColorPickerF.SetActive(false);
    }
}

using UnityEngine;
using System.Collections;
using System;

public class ColorfulBackground : MonoBehaviour
{
    public static Color colorIni;
    public static Color colorFin;
    public float duration = 5f;
    Color lerpedColor = Color.white;

    private float t = 0;
    private bool flag;

    Camera _cam;
    // Use this for initialization
    void Start()
    {
        _cam = GetComponent<Camera>();
    }

    void Update()
    {
        lerpedColor = Color.Lerp(colorIni, colorFin, t);
        _cam.backgroundColor = lerpedColor;

        if (flag == true)
        {
            t -= Time.deltaTime / duration;
            if (t < 0.01f)
                flag = false;
        }
        else
        {
            t += Time.deltaTime / duration;
            if (t > 0.99f)
                flag = true;
        }
    }
}
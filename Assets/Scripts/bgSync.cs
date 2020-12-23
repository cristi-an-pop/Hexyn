using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgSync : MonoBehaviour
{
    public static Color defaultColor = Color.red;

    public float changeColorEvery = 1f;
    private float _colorstep;
    private Color[] _colors = new Color[7];
    private int _i;

    private Color _lerpedColor = Color.magenta;

    SpriteRenderer _background;

    string htmlRed = "#cc0000";
    string htmlPurple = "#9400D3";
    string htmlBlue = "#0000b3";
    string htmlGreen = "#32CD32";
    string htmlCyan = "#00CED1";
    string htmlYellow = "#FFDC00";

    public Color red_color;
    public Color blue_color;
    public Color green_color;
    public Color cyan_color;
    public Color purple_color;
    public Color yellow_color;

    void Awake()
    {
        ColorUtility.TryParseHtmlString(htmlRed, out red_color);
        ColorUtility.TryParseHtmlString(htmlPurple, out purple_color);
        ColorUtility.TryParseHtmlString(htmlBlue, out blue_color);
        ColorUtility.TryParseHtmlString(htmlGreen, out green_color);
        ColorUtility.TryParseHtmlString(htmlCyan, out cyan_color);
        ColorUtility.TryParseHtmlString(htmlYellow, out yellow_color);

        defaultColor = PlayerPrefsX.GetColor("BackgroundColor");

        _colors[0] = purple_color;
        _colors[1] = red_color;
        _colors[2] = yellow_color;
        _colors[3] = green_color;
        _colors[4] = cyan_color;
        _colors[5] = blue_color;
        _colors[6] = purple_color;
    }

    void Start()
    {
        _background = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (BCButtons.EpilepticAttack == 0)
            _background.color = defaultColor;
        else
        {
            if (_colorstep < changeColorEvery)
            {
                _lerpedColor = Color.Lerp(_colors[_i], _colors[_i + 1], _colorstep);
                _background.color = _lerpedColor;
                _colorstep += 0.002f;
            }
            else
            {
                _colorstep = 0;

                if (_i < (_colors.Length - 2))
                {
                    _i++;
                }
                else
                {
                    _i = 0;
                }
            }
        }
    }
}

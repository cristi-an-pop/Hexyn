using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour
{
    private Camera _Camera;

    public float changeColorEvery = 1f;
    private float _colorstep;
    private Color[] _colors = new Color[7];
    private int _i;

    private Color _lerpedColor = Color.magenta;

    void Awake()
    {
        _colors[0] = Color.magenta;
        _colors[1] = Color.red;
        _colors[2] = Color.yellow;
        _colors[3] = Color.green;
        _colors[4] = Color.cyan;
        _colors[5] = Color.blue;
        _colors[6] = Color.magenta;

        _Camera = GetComponent<Camera>();
    }

    void Update()
    {
        if (BCButtons.EpilepticAttack == 1)
        {
            if (_colorstep < changeColorEvery)
            {
                _lerpedColor = Color.Lerp(_colors[_i], _colors[_i + 1], _colorstep);
                _Camera.backgroundColor = _lerpedColor;
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

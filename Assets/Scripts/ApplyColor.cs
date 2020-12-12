using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyColor : MonoBehaviour
{
    public FlexibleColorPicker fcp1;
    public FlexibleColorPicker fcp2;
    public int cnt = 0;

    private void Start()
    {
        //ColorfulBackground.colorIni = Color.red;
        //ColorfulBackground.colorFin = Color.red;
    }
    private void Update()
    {
        //ColorfulBackground.colorIni = fcp1.color;
        //ColorfulBackground.colorFin = fcp2.color;
    }
}

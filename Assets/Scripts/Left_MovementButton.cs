using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Left_MovementButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool buttonPressed;
    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    public void Click()
    {
        if (buttonPressed == true)
            Player.movement = 1f;
        else if (buttonPressed == false)
            Player.movement = 0f;
    }

}

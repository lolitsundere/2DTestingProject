using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseMoveInHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public static bool MouseIn;

    public void OnPointerEnter(PointerEventData eventData)
    {
        MouseIn = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        MouseIn = false;
    }
}

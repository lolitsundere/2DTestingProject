using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEventHandler : MonoBehaviour
{
    /// <summary>
    /// 在鼠标点击时触发
    /// </summary>
    public event Action<GameObject> ClickEvent;

    public GameObject Highlight;
    
    private GameObject highlight;
    private void OnMouseDown()
    {
        if (ClickEvent != null && !MouseMoveInHandler.MouseIn)
        {
            ClickEvent(gameObject);
        }
    }

    private void OnMouseEnter()
    {
        if (!MouseMoveInHandler.MouseIn)
        {
            highlight = Instantiate(Highlight, transform);
            highlight.transform.position = transform.position;
        }
    }

    private void OnMouseExit()
    {
        Destroy(highlight);
    }
}

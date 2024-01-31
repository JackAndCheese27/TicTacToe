using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCursor : MonoBehaviour
{
    public bool MouseDetected;
    void Start()
    {
        MouseDetected = false;
    }

    private void OnMouseOver()
    {
        
        MouseDetected = true;
    }

    private void OnMouseExit()
    {
        MouseDetected = false;
    }
}

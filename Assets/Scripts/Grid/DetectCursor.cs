using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCursor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public bool MouseDetected;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
        MouseDetected = false;
    }

    private void OnMouseOver()
    {
        spriteRenderer.enabled = true;
        MouseDetected = true;
    }

    private void OnMouseExit()
    {
        spriteRenderer.enabled = false;
        MouseDetected = false;
    }
}

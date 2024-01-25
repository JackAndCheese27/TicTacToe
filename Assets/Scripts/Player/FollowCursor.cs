using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    private Vector2 mousePosition;

    private float HorizontalBound;
    private float VerticalBound;
    
    private float SpriteSize = 8;

    private Camera mainCamera;
    void Start()
    {
        Cursor.visible = false;
        
        mainCamera = Camera.main;

        VerticalBound = mainCamera.orthographicSize;
        HorizontalBound = mainCamera.orthographicSize * mainCamera.aspect;
    }

    void Update()
    {
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        Vector2 nextPosition = mousePosition;
        
        nextPosition.x = Mathf.Clamp(nextPosition.x, -HorizontalBound, HorizontalBound) + SpriteSize/2;
        nextPosition.y = Mathf.Clamp(nextPosition.y, -VerticalBound, VerticalBound) - SpriteSize/2;
        
        transform.position = nextPosition;
    }
}

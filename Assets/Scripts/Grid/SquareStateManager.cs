using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareStateManager : MonoBehaviour
{
    public SquareState currentSquareState = SquareState.Empty;
    [SerializeField] private TurnManager turnManager;
    [SerializeField] private DetectCursor detectCursor;

    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite xSprite;
    [SerializeField] private Sprite oSprite;
    [SerializeField] private Sprite highlightSprite;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        detectCursor = GetComponent<DetectCursor>();
        turnManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<TurnManager>();
    }

    public void Update()
    {
        if (currentSquareState == SquareState.Empty)
        {
            if (detectCursor.MouseDetected)
            {
                spriteRenderer.sprite = highlightSprite;
                
                if (Input.GetMouseButtonDown(0))
                {
                    if (turnManager.isXTurn)
                    {
                        currentSquareState = SquareState.X;
                        spriteRenderer.sprite = xSprite;
                        Debug.Log("X Placed");
                    }
                    else
                    {
                        currentSquareState = SquareState.O;
                        spriteRenderer.sprite = oSprite;
                        Debug.Log("O Placed");
                    }
                    
                    turnManager.EndTurn();
                } 
            }
            else
            {
                spriteRenderer.sprite = null;
                
            }
        }
    }
}

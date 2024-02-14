using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class TurnManager : MonoBehaviour
{
    public bool isXTurn;
    [SerializeField] private GridManager gridManager;
    [SerializeField] private WinDetection winDetection;

    private int currentTurn;
    public void Start()
    {
        CoinFlip();
        currentTurn = 0;
    }

    public void EndTurn()
    {
        currentTurn++;
        isXTurn = !isXTurn;
        gridManager.UpdateSquareStates();
        
        if (winDetection.CheckForWin() || currentTurn >= 9)
        {
            EndGame();
        }
    }

    public void CoinFlip()
    {
        Random gen = new Random();
        int prob = gen.Next(100);
        isXTurn = prob < 50;

    }

    public void EndGame()
    {
        gridManager.ResetGrid();
        currentTurn = 0;
        CoinFlip();
    }
    
}

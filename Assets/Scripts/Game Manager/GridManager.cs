using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    
    public SquareStateManager[] gridSquares = new SquareStateManager[9];

    
    [SerializeField] public SquareState[] squareStates = new SquareState[9];

    public void Start()
    {
        UpdateSquareStates();
    }
    
    
    public void UpdateSquareStates()
    {
        for (int i = 0; i < gridSquares.Length; ++i)
        {
            squareStates[i] = gridSquares[i].currentSquareState;
        }
    }

    public void ResetGrid()
    {
        foreach (var square in gridSquares)
        {
            square.currentSquareState = SquareState.Empty;
        }
        
        UpdateSquareStates();
    }
}

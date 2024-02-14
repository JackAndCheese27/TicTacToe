using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetection : MonoBehaviour
{
    [SerializeField] private GridManager gridManager;

    [SerializeField] private ScoreTracker xScoreTracker;

    [SerializeField] private ScoreTracker oScoreTracker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public bool CheckForWin()
    {
        int xNumber = 0;
        int oNumber = 0;

        foreach (var square in gridManager.squareStates)
        {
            if (square == SquareState.X)
            {
                xNumber++;
            }

            if (square == SquareState.O)
            {
                oNumber++;
            }
        }

        if (xNumber >= 3)
        {
            if (CheckForThreeInARow(SquareState.X))
            {
                xScoreTracker.IncreaseScore();
                return true;
            }
        }

        if (oNumber >= 3)
        {
            if (CheckForThreeInARow(SquareState.O))
            {
                oScoreTracker.IncreaseScore();
                return true;
            }
        }
        
        return false;
    }

    
    private bool CheckForThreeInARow(SquareState stateToCheck)
    {
        List<int> positionsOccupied = new List<int>();

        int i = 0;
        foreach (var square in gridManager.squareStates)
        {
            if (square == stateToCheck)
            {
                positionsOccupied.Add(i);
            }

            i++;
        }

        if (positionsOccupied.Contains(0) && positionsOccupied.Contains(1) && positionsOccupied.Contains(2))
        {
            return true;
        }
        
        if (positionsOccupied.Contains(0) && positionsOccupied.Contains(3) && positionsOccupied.Contains(6))
        {
            return true;
        }
        
        if (positionsOccupied.Contains(0) && positionsOccupied.Contains(4) && positionsOccupied.Contains(8))
        {
            return true;
        }
        
        if (positionsOccupied.Contains(3) && positionsOccupied.Contains(4) && positionsOccupied.Contains(5))
        {
            return true;
        }
        
        if (positionsOccupied.Contains(1) && positionsOccupied.Contains(4) && positionsOccupied.Contains(7))
        {
            return true;
        }
        
        if (positionsOccupied.Contains(2) && positionsOccupied.Contains(4) && positionsOccupied.Contains(6))
        {
            return true;
        }
        
        if (positionsOccupied.Contains(6) && positionsOccupied.Contains(7) && positionsOccupied.Contains(8))
        {
            return true;
        }
        
        if (positionsOccupied.Contains(2) && positionsOccupied.Contains(5) && positionsOccupied.Contains(8))
        {
            return true;
        }
        
        return false;
    }
}

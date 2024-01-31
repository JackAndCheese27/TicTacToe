using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public bool isXTurn = true;
    [SerializeField] private GridManager gridManager;
    

    public void EndTurn()
    {
        gridManager.UpdateSquareStates();
        isXTurn = !isXTurn;
    }
}

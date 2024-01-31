using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorManager : MonoBehaviour
{
    [SerializeField] private TurnManager turnManager;

    [SerializeField] private SpriteRenderer xIndicator;
    [SerializeField] private SpriteRenderer oIndicator;
    public void Update()
    {
        if (turnManager.isXTurn)
        {
            xIndicator.enabled = true;
            oIndicator.enabled = false;
        }
        else
        {
            xIndicator.enabled = false;
            oIndicator.enabled = true;
        }
    }
}

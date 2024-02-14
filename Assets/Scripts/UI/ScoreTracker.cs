using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    private int score;
    private TextMeshProUGUI text;

    public void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        
        ResetScore();
    }

    public void IncreaseScore()
    {
        score++;
        text.text = score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        text.text = score.ToString();
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIManagerScript : MonoBehaviour
{
    public int score;
    
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void ScoreUp()
    {
        score += 20;
        UpdateScoreUI();
    }

    public void ScoreDown()
    {
        score -= 20;
        UpdateScoreUI();
    }

    public void ScoreReset()
    {
        score = 0;
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
    }

}

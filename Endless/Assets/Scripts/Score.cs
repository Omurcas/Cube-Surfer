using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public int score;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
     
    }

    public void AddPoint()
    {
        score += 5;
        scoreText.text = score.ToString();
    }

    public void MinusPoint()
    {
        if(score ==0||score == 1)
        {
            score = 0;
            scoreText.text = score.ToString();
        }
        else
        {
            score -= 2;
            scoreText.text = score.ToString();
        }

            
        
        
    }
}

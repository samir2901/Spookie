using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public Text scoreDisplay;
    private void Update()
    {
        scoreDisplay.text = "Score : " + score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.CompareTag("Obstacle"))
        {
            score += 10;
            //Debug.Log("Score:" + score);
        }
    }
}

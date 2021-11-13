using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    int playerScore; // variable to store score of the player
    public Text scoreText; // text variable to display score in UI
    void Start()
    {
        playerScore = 0;
        scoreText.text = "Score : " + playerScore;
    }
    public void addScore()
    {
        playerScore += 1;
        scoreText.text = "Score : " + playerScore;
    }
}

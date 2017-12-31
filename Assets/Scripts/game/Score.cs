using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    [SerializeField] private int scoreMax;
    private int score;
    private Text scoreDisplay;
    
	// Use this for initialization
	void Start () {
        score = 0;
        if (GameObject.Find("scoreDisplay"))
        {
            scoreDisplay = GameObject.Find("scoreDisplay").GetComponent<Text>();
        }
        scoreDisplay.text = score + " / " + scoreMax;

    }
	
    public void IncreaseScore()
    {
        score++;
        scoreDisplay.text = score + " / " + scoreMax;
        if (score == scoreMax)
        {
            Application.LoadLevel("GameWon");
        }
    }

    public int ScoreNbr()
    {
        return score;
    }
}

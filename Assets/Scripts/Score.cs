using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public string scoreText = "Current Score: ";
    public Text scoreContainer;
    public int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        scoreContainer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Always update the score to show how many coins are collected
        scoreContainer.text = scoreText + currentScore;
    }
}

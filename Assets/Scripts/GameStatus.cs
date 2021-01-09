using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    // Config Params
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 83;
    [SerializeField] TextMeshProUGUI scoreText;

    //State variables
    [SerializeField] int CurrentScore = 0;

    private void Start()
    {
        scoreText.text = CurrentScore.ToString();     
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void addToScore()  
    {
        CurrentScore += pointsPerBlockDestroyed;
        scoreText.text = CurrentScore.ToString();
    }
    
}

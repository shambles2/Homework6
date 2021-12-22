using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int GameScore { get; set; }
    private void Start()
    {
        GameScore = 0;
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = "Score: " + GameScore.ToString();
    }
}

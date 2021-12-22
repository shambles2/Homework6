using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDetection : MonoBehaviour
{
    Score score;
    public GameObject player;
    private void Start()
    {
        score = GameObject.FindWithTag("Score").GetComponent<Score>();
        player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        if((int)transform.position.z == (int)player.transform.position.z)
        {
            this.GetComponent<Renderer>().material.color = Color.red;
            score.GameScore++;
            this.gameObject.GetComponent<ObstacleDetection>().enabled = false;
        }
    }
}

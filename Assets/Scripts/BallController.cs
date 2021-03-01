using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;

    //課題追加
    private int score = 0;
    private GameObject scoreText;

    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");

        //課題追加
        this.scoreText = GameObject.Find("ScoreText");
    }

    void Update()
    {
        if(this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    //課題追加
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
            this.score += 20;
        }
        else if(other.gameObject.tag == "LargeCloudTag" || tag == "SmallCloudTag")
        {
            this.score += 30;
        }
        this.scoreText.GetComponent<Text>().text = "Score " + score;
    }
}

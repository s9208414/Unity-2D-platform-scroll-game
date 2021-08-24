using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public int score;
    public GameObject Q1;
    public GameObject player;
    public GameObject Gscore;
    // Start is called before the first frame update


    void Start()
    {
        GetComponent<Text>().text = "分數:" + 0;
    }

    // Update is called once per frame
    void Update()
    {
        addScore();

    }
    public void addScore()
    {
        //Gscore.GetComponent<Text>().text = "你的分數: " + this.score;
        recordScore.score = this.score;
        GetComponent<Text>().text = "分數:" + this.score;
        player.GetComponent<Platformer>().score = this.score;
        
    }

    
}


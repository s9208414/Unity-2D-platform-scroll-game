﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato2 : MonoBehaviour
{
    public GameObject Q2;
    public int eatPotato2;
    public int score;
    public GameObject ss;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.score = 25;
            ss.GetComponent<scoreScript>().score += this.score;

            gameObject.SetActive(false);
            Destroy(this.GetComponent<BoxCollider2D>());


        }
    }

}
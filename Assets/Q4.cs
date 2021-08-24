using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q4 : MonoBehaviour
{
    public GameObject Question4;
    public GameObject potato4;
    public GameObject ScoreText;
    public bool isAnswer = false;
    public bool canmove;
    public bool trigger;
    public GameObject player;
    public int score;

    public GameObject ss;
    public bool eatPotato4;
    
    public bool coll;
    public GameObject stone;
    public GameObject playerCam;
    public GameObject bigTree;
    public GameObject hint;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        check();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            print("觸發Q4");
            if (isAnswer == false)
            {

                Question4.SetActive(true);
                player.GetComponent<Platformer>().canMove = false;
                
                Destroy(this.GetComponent<BoxCollider2D>());
                coll = true;
            }

            //print("isAnswer: " + this.isAnswer);

        }
    }

    void check()
    {
        if ((Input.GetKeyDown(KeyCode.Alpha1)) && (this.isAnswer == false) && (coll == true))
        {
            print("觸發Q4的1");
            Question4.SetActive(false);

            potato4.SetActive(true);
            potato4.GetComponent<Rigidbody2D>().gravityScale = 1;
            player.GetComponent<Platformer>().canMove = true;
            this.isAnswer = true;
            bigTree.GetComponent<bigTree>().canZoomOut = true;
            stone.GetComponent<Rigidbody2D>().gravityScale = 2f;
            stone.SetActive(true);
            stone.GetComponent<stone>().stoneRun = true;
            hint.SetActive(true);
        }
        else if ((Input.GetKeyDown(KeyCode.Alpha2) && (this.isAnswer == false)) && (coll == true))
        {
            print("觸發Q4的2");
            Question4.SetActive(false);
            player.GetComponent<Platformer>().canMove = true;
            this.isAnswer = true;
            bigTree.GetComponent<bigTree>().canZoomOut = true;
            stone.GetComponent<Rigidbody2D>().gravityScale = 2f;
            stone.SetActive(true);
            stone.GetComponent<stone>().stoneRun = true;
            hint.SetActive(true);
        }


        //print(this.eatPotato1);

    }

}




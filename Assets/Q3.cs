using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q3 : MonoBehaviour
{
    public GameObject Question3;
    public GameObject potato3;
    public GameObject ScoreText;
    public bool isAnswer = false;
    public bool canmove;
    public bool trigger;
    public GameObject player;
    public int score;

    public GameObject ss;
    public bool eatPotato3;
    public GameObject cloud;
    public bool coll;
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

            print("觸發Q3");
            if (isAnswer == false)
            {
                
                Question3.SetActive(true);
                player.GetComponent<Platformer>().canMove = false;
                player.GetComponent<Rigidbody2D>().gravityScale = 0;
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
            print("觸發Q3的1");
            player.GetComponent<Rigidbody2D>().gravityScale = 1;
            Question3.SetActive(false);
            player.GetComponent<Platformer>().canMove = true;
            this.isAnswer = true;
        }
        else if ((Input.GetKeyDown(KeyCode.Alpha2) && (this.isAnswer == false)) && (coll == true))
        {
            print("觸發Q3的2");
            player.GetComponent<Rigidbody2D>().gravityScale = 1;
            Question3.SetActive(false);
            cloud.SetActive(true);
            cloud.GetComponent<cloud>().fly = true;
            potato3.SetActive(true);
            player.GetComponent<Platformer>().canMove = true;
            this.isAnswer = true;
        }


        //print(this.eatPotato1);

    }

}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q2 : MonoBehaviour
{
    public GameObject Question2;
    public GameObject potato2;
    public GameObject ScoreText;
    public bool isAnswer = false;
    public bool canmove;
    public bool trigger;
    public GameObject player;
    public int score;
    public GameObject bridge;
    public GameObject ss;
    public bool eatPotato2;
    public GameObject playerCam;
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


            if (isAnswer == false)
            {
                print("觸發Q2");
                Question2.SetActive(true);
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
            print("觸發Q2的1");
            Question2.SetActive(false);
            //player.GetComponent<Platformer>().canMove = true;
            this.isAnswer = true;

            bridge.AddComponent<Rigidbody2D>();
            playerCam.GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = null;

            
        }
        else if ((Input.GetKeyDown(KeyCode.Alpha2) && (this.isAnswer == false)) && (coll == true))
        {
            print("觸發Q2的2");
            potato2.SetActive(true);
            potato2.GetComponent<Rigidbody2D>().gravityScale = 1;

            Question2.SetActive(false);
            player.GetComponent<Platformer>().canMove = true;
            this.isAnswer = true;

        }


        //print(this.eatPotato1);

    }

}

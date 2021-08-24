using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Q1 : MonoBehaviour
{
    public GameObject Question1;
    public GameObject potato1;
    public GameObject ScoreText;
    public bool isAnswer = false;
    public bool canmove;
    public bool trigger;
    public GameObject player;
    public int score;
    
    public GameObject ss;
    public bool eatPotato1;
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

            print("觸發Q1");
            if (isAnswer == false)
            {
                
                Question1.SetActive(true);
                player.GetComponent<Platformer>().canMove = false;
                Destroy(this.GetComponent<BoxCollider2D>());
                coll = true;
            }
            
            //print("isAnswer: " + this.isAnswer);

        }
    }

    void check()
    {
        if ((Input.GetKeyDown(KeyCode.Alpha1))&&(this.isAnswer == false)&&(coll == true))
        {

            print("觸發Q1的1");
            potato1.SetActive(true);
            potato1.GetComponent<Rigidbody2D>().gravityScale = 1;
            


            Question1.SetActive(false);
            player.GetComponent<Platformer>().canMove = true;
            this.isAnswer = true;
            
            
        }
        else if ((Input.GetKeyDown(KeyCode.Alpha2) && (this.isAnswer == false)) && (coll == true))
        {
            print("觸發Q1的2");
            Question1.SetActive(false);
            player.GetComponent<Platformer>().canMove = true;
            this.isAnswer = true;
            
        }
        

        //print(this.eatPotato1);

    }
    
}

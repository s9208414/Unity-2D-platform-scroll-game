using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    public bool fly;
    public bool onCloud;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((fly == true) && (this.GetComponent<Transform>().position.x > 83))
        {
            this.GetComponent<Transform>().position = new Vector3((this.GetComponent<Transform>().position.x)-0.5f, 7.4f, 0);
        }
        if (onCloud == true)
        {
            fly = false;
            player.GetComponent<Platformer>().canMove = false;
            this.GetComponent<SpriteRenderer>().flipX = true;
            
            if (this.GetComponent<Transform>().position.x < 92)
            {
                this.GetComponent<Transform>().position = new Vector3((this.GetComponent<Transform>().position.x) + 0.12f, 7.4f, 0);
                player.GetComponent<Transform>().position = new Vector3(player.GetComponent<Transform>().position.x + 0.12f, player.GetComponent<Transform>().position.y, 0);
                
            }
            if (this.GetComponent<Transform>().position.x >= 92)
            {
                player.GetComponent<Platformer>().canMove = true;
            }
        }
    }
    
}

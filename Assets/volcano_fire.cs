using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volcano_fire : MonoBehaviour
{
    public GameObject player;
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
            this.score = -10;
            ss.GetComponent<scoreScript>().score += this.score;
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.GetComponent<Rigidbody2D>().velocity.x, 10);

        }
        
    }
}

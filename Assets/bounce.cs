using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public GameObject player;
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
            GetComponent<Transform>().position = new Vector3(69.77f, -2.202f, 0);
            GetComponent<Transform>().localScale = new Vector3(0.4f, 1.156584f, 0);
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.GetComponent<Rigidbody2D>().velocity.x, 25);

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<Transform>().position = new Vector3(69.77f, -4.632f, 0);
            GetComponent<Transform>().localScale = new Vector3(0.4f, 0.2076481f, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneTrigger : MonoBehaviour
{
    public int score;
    public GameObject ss;
    public GameObject stone;
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
            print("已扣分");
            this.score = -15;
            ss.GetComponent<scoreScript>().score += this.score;
        }
    }
}

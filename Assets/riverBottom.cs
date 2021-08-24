using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class riverBottom : MonoBehaviour
{
    public GameObject playerCam;
    public Transform Tplayer;
    public GameObject Gplayer;
    public int score;
    public GameObject ss;
    public GameObject bridge;
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
            Gplayer.GetComponent<Transform>().position = new Vector3(43, 0, 0);
            Gplayer.GetComponent<Platformer>().canMove = true;
            playerCam.GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = Tplayer;
        }
        else if (collision.gameObject.tag == "bridge")
        {
            Destroy(bridge.GetComponent<BoxCollider2D>());
            Destroy(bridge.GetComponent<EdgeCollider2D>());
        }
    }
}

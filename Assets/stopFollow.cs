using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopFollow : MonoBehaviour
{
    public GameObject playerCam;
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
            print("結束");
            playerCam.GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = null;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("結束");
            playerCam.GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = null;
        }
    }
}

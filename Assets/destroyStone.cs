using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyStone : MonoBehaviour
{
    public GameObject stone;
    public bool canZoomOut = true;
    public GameObject playerCam;
    public GameObject bigTree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "stone")
        {
            stone.SetActive(false);

            bigTree.GetComponent<bigTree>().canZoomOut = false;
            /*canZoomOut = false;
            stone.GetComponent<stone>().beenDestroy = true;*/
            Destroy(stone.GetComponent<BoxCollider2D>());
            Destroy(stone.GetComponent<Rigidbody2D>());
        }
    }
}

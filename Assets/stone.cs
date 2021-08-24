using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    public bool stoneRun;
    public bool canZoomOut;
    public GameObject playerCam;
    public bool beenDestroy;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (stoneRun == true)
        {
            
            transform.Rotate(Vector3.forward * -4);
            this.GetComponent<Transform>().position = new Vector3(this.GetComponent<Transform>().position.x + 0.12f, this.GetComponent<Transform>().position.y, 0);
            
        }
    }
    







}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigTree : MonoBehaviour
{
    public bool inSea;
    public GameObject playerCam;
    public bool canZoomOut;
    public GameObject hint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (canZoomOut == true && playerCam.GetComponent<Cinemachine.CinemachineVirtualCamera>().m_Lens.OrthographicSize < 20)
        {
            //print("可以縮小" + canZoomOut);
            playerCam.GetComponent<Cinemachine.CinemachineVirtualCamera>().m_Lens.OrthographicSize = playerCam.GetComponent<Cinemachine.CinemachineVirtualCamera>().m_Lens.OrthographicSize + 0.5f;
            hint.SetActive(true);
        }
        if (canZoomOut == false && playerCam.GetComponent<Cinemachine.CinemachineVirtualCamera>().m_Lens.OrthographicSize > 5)
        {
            //print("不可縮小" + canZoomOut);
            playerCam.GetComponent<Cinemachine.CinemachineVirtualCamera>().m_Lens.OrthographicSize = playerCam.GetComponent<Cinemachine.CinemachineVirtualCamera>().m_Lens.OrthographicSize - 0.5f;
            hint.SetActive(false);

        }
        

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "stone")
        {
            if (inSea == false)
            {
                print("碰到樹");
                if (GetComponent<Transform>().rotation.z > -90)
                {
                    this.GetComponent<Transform>().position = new Vector3(this.GetComponent<Transform>().position.x + 1f, this.GetComponent<Transform>().position.y, 0);
                    transform.Rotate(Vector3.forward * -10);
                }
            }
            

        }
        else if (collision.gameObject.tag == "sea")
        {
            if (inSea == false)
            {
                if (GetComponent<Transform>().rotation.z != -90)
                {
                    this.GetComponent<Transform>().position = new Vector3(this.GetComponent<Transform>().position.x, this.GetComponent<Transform>().position.y, 0);
                    transform.localEulerAngles = new Vector3(0, 0, -90);
                }
                inSea = true;

            }
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitCloud : MonoBehaviour
{
    public GameObject cloud;
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
        cloud.SetActive(false);
        Destroy(cloud.GetComponent<BoxCollider2D>());
    }
}

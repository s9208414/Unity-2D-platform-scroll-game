using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneTriggerController : MonoBehaviour
{
    public GameObject stoneTrigger;
    public GameObject stone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stoneTrigger.GetComponent<Transform>().position = stone.GetComponent<Transform>().position;
        stoneTrigger.GetComponent<Transform>().rotation = stone.GetComponent<Transform>().rotation;
    }
}

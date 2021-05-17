using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Bottle")
        {
            col.gameObject.transform.position = new Vector3(0.2f, transform.position.y, transform.position.z);
        } else
        {
            col.gameObject.transform.position = new Vector3(-0.2f, transform.position.y, transform.position.z);
        }
    }
}

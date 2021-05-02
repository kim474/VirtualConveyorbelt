using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBottle : MonoBehaviour
{
    public GameObject Bottle;
    public float Timer = 3;


    void Start()
    {
    }

    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            Instantiate(Bottle, new Vector3(1, 1, 0), Quaternion.identity);
            Timer = 3f;
        }
    }
}

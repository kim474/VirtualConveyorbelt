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
            //  Instantiate(Bottle, new Vector3(0.1f, 1.3f, -7.0f), Quaternion.identity);
            float xpos = Random.Range(-0.2f, 0.2f);
            float angle = Random.Range(-60f, 60f);
            Quaternion qRotation = Quaternion.Euler(0f, 0f, angle);
            Instantiate(Bottle, new Vector3(xpos, 1.3f, -7.0f), qRotation);
            Timer = 3f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBottle : MonoBehaviour
{
    public GameObject Bottle;
    public GameObject Bottle_labeled;
    List<GameObject> Bottles = new List<GameObject>();

    public float Timer = 3;

    void Start()
    {
        Bottles.Add(Bottle);
        Bottles.Add(Bottle_labeled);
    }

    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            float xpos = Random.Range(-0.2f, 0.2f);
            float angle = Random.Range(-50f, 50f);
            int bottleIndex = Random.Range(0, 2);

            Quaternion qRotation = Quaternion.Euler(angle, angle, angle);
            Instantiate(Bottles[bottleIndex], new Vector3(xpos, 1.3f, -7.0f), qRotation);
            Timer = 3f;
        }
    }
}

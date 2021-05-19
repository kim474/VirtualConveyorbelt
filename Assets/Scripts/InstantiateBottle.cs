using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBottle : MonoBehaviour
{
    public GameObject Bottle;
    public GameObject Bottle_labeled;
    public GameObject test; // ** 이물질이 들어온 상황을 가정하기 위해 추가한 것으로, 실제 프로젝트 동작 시에는 이 줄 삭제**
    List<GameObject> Bottles = new List<GameObject>();

    public float Timer = 3;

    void Start()
    {
        Bottles.Add(Bottle);
        Bottles.Add(Bottle_labeled);
        Bottles.Add(test); // **이물질이 들어온 상황을 가정하기 위해 추가한 것으로, 실제 프로젝트 동작 시에는 이 줄 삭제**
    }

    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            float xpos = Random.Range(-0.2f, 0.2f);
            float angle = Random.Range(-50f, 50f);
            int bottleIndex = Random.Range(0, 3); // **실제 프로젝트 동작 시에는 (0,2)로 변경**

            Quaternion qRotation = Quaternion.Euler(angle, angle, angle);
            Instantiate(Bottles[bottleIndex], new Vector3(xpos, 1.3f, -7.0f), qRotation);
            Timer = 3f;
        }
    }
}

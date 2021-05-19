using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//쓰레기 자동 생성
public class InstantiateBottle : MonoBehaviour
{
    public GameObject Bottle;
    public GameObject Bottle_labeled;

    public GameObject Can_pepsi;
    public GameObject Can_beer;

    public float Timer = 3;

    List<GameObject> Bottles = new List<GameObject>(); //Bottle prefab들을 담은 리스트
    List<GameObject> Cans = new List<GameObject>(); //Can prefab들을 담은 리스트
    List<GameObject> Trash = new List<GameObject>();  //모든 쓰레기 prefab을 담은 리스트


    void Start()
    {
        Bottles.Add(Bottle);
        Bottles.Add(Bottle_labeled);

        Cans.Add(Can_pepsi);
        Cans.Add(Can_beer);

        Trash.Add(Bottle);
        Trash.Add(Bottle_labeled);
        Trash.Add(Can_pepsi);
        Trash.Add(Can_beer);

    }

    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            float xpos = Random.Range(-0.2f, 0.2f);
            float angle = Random.Range(-50f, 50f);
            int trashIndex = Random.Range(0, 4); // Random.Range(0,gamobject 종류의 수)**

            Quaternion qRotation = Quaternion.Euler(angle, angle, angle);
            Instantiate(Trash[trashIndex], new Vector3(xpos, 1.3f, -7.0f), qRotation);
            Data.inputTrash += 1;
            Timer = 3f;
        }
    }
}

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
    public GameObject etc;

    public float Timer = 4;
    public static bool inputNew = false;
    public static string classNumber;

    public static List<GameObject> Bottles = new List<GameObject>(); //Bottle prefab들을 담은 리스트
    public static List<GameObject> Cans = new List<GameObject>(); //Can prefab들을 담은 리스트
    public static List<GameObject> Trash = new List<GameObject>();  //모든 쓰레기 prefab을 담은 리스트
   


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
        Trash.Add(etc);

    }

    void Update()
    {
        Timer -= Time.deltaTime;
        int trashIndex = Random.Range(0, 5); // Random.Range(0,gamobject 종류의 수)**
        float xpos = Random.Range(-0.2f, 0.2f);
        float angle = Random.Range(-50f, 50f);
        int canIndex = Random.Range(0, 2);
        Quaternion qRotation = Quaternion.Euler(angle, angle, angle);


        if (Timer <= 0f)
        {

            if (inputNew == true)
            {
                if (classNumber == "0")
                {
                    print("INPUT NEW PET!");
                    Instantiate(Bottles[1], new Vector3(xpos, 1.3f, -7.0f), qRotation);

                }
                else if (classNumber == "26")
                {
                    print("INPUT NEW CAN!");
                    Instantiate(Cans[canIndex], new Vector3(xpos, 1.3f, -7.0f), qRotation);
                }
                else
                {
                    print("INPUT NEW OBJECT!");
                    Instantiate(Trash[4], new Vector3(xpos, 1.3f, -7.0f), qRotation);
                }
               // Data.inputTrash += 1;
                inputNew = false;
               
            }
            else
            {
                Instantiate(Bottles[0], new Vector3(xpos, 1.3f, -7.0f), qRotation);
              //  Data.inputTrash += 1;
            }
 
             
            Timer = 4f;
        }
    }
    
    public static void getClass(string classNum)
    {
        if (classNum == "0")
        {
            print("INPUT NEW PET!");

        } else if(classNum == "26")
        {
            print("INPUT NEW CAN!");
        }
        else
        {
            print("INPUT NEW OBJECT!");
        }
        classNumber = classNum;
        inputNew = true;
    }
}

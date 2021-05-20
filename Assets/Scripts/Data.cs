using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public string item = "Pet"; //컨베이어벨트 종류
    public int uptime = 0; //컨베이어 가동 시간
    public static int inputTrash = 0; //배출되는 모든 쓰레기의 수 
    public static int recyclingTrash = 0; //재활용되는 쓰레기의 수
    public static float recyclingRate = 0.0f; //재활용률
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CountTime", 0.0f, 1.0f);
        InvokeRepeating("Status", 0.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
     }

    void Status()
    {
        if (inputTrash != 0)
        {
            recyclingRate = (float)recyclingTrash / (float)inputTrash;
        }
        print("총 쓰레기: " + inputTrash + " / 재활용된 쓰레기: " + recyclingTrash + " / 재활용률: " + recyclingRate * 100 + "% / " + uptime + "초째 가동 중 ###모든 데이터는 휴지통에 들어간 쓰레기에 한해 집계됨###");
    }

    void CountTime()
    {
        uptime += 1;
    }

}

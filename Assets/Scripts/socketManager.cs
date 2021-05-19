using UnityEngine;
using WebSocketSharp;
public class socketManager : MonoBehaviour
{
    WebSocket ws;
    private void Start()
    {
        Debug.Log("start");
        ws = new WebSocket("ws://3.34.99.134:8080");
        ws.Connect();
        ws.OnMessage += (sender, e) =>
        {
            Debug.Log("Message Received from "+((WebSocket)sender).Url+", Data : "+e.Data);
        };
    }
private void Update()
    {
        if(ws == null)
        {
            return;
        }
if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("spacebar");
            ws.Send("Hello");
        }  
    }
}
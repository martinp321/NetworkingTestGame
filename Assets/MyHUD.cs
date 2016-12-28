using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyHUD : NetworkManager
{
    public void MyStartHost()
    {
        Debug.Log("Starting Host at " + Time.timeSinceLevelLoad);
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log("started Host at " + Time.timeSinceLevelLoad);
    }

    public override void OnStartClient(NetworkClient myClient)
    {
        base.OnStartClient(myClient);
        Debug.Log("client start requested " + Time.timeSinceLevelLoad);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);
        Debug.Log(conn.address + " client has connected " + Time.timeSinceLevelLoad);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Sockets;
using System.Text;


public class Socket_Agent : MonoBehaviour
{
    public string ip = "127.0.0.1";
    public int port = 60000;
    private Socket client;
    [SerializeField]
    private string dataOut, dataIn;

    protected string ServerRequest(string dataOut){
        this.dataOut = dataOut;
        this.dataIn = SendAndReceive(dataOut);
        return this.dataIn;
    }

    private string SendAndReceive(string dataOut){
        client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        client.Connect(ip, port);
        if(!client.Connected){
            Debug.LogError("Connection failed");
            return null;
        }

        byte[] byteArray = Encoding.UTF8.GetBytes(dataOut);
        client.Send(byteArray);
        byte[] bytes = new byte[4000];
        int receivedBytes = client.Receive(bytes);

        string receivedString = Encoding.UTF8.GetString(bytes, 0, receivedBytes);
        client.Close();
        return receivedString;
    }
}

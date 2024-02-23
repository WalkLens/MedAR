using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lunarcom_Agent : Socket_Agent
{
    // Start is called before the first frame update
    void Start()
    {
        string requestData = "Hi from Unity!";
        string responseData = ServerRequest(requestData);

        Debug.Log(responseData);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

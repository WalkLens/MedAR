using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class Lunarcom_Agent : Socket_Agent
{
    public TextMeshProUGUI returnData;
    //public string returnData;
    // Start is called before the first frame update
    void Start()
    {
        //requestData = "Hi from Unity!";
        //responseData = ServerRequest(requestData);

        //Debug.Log(responseData);
    }

    // Update is called once per frame
    void Update()
    {
        if (returnData.text.Length >= 1)
        {
            Debug.Log(returnData);
        }
        else
        {
            Debug.LogError("text is null");
        }
    }

    public void ReturnServerRequest(string requestData)
    {
        returnData.text = ServerRequest(requestData);
    }
}

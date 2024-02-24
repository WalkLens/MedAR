using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lunarcom_Agent : Socket_Agent
{
    public TextMeshProUGUI returnData;
   
    public void ReturnServerRequest(string requestData)
    {
        returnData.text = ServerRequest(requestData);
    }
}

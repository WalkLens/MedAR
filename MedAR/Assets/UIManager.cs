using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject startButton;
    public GameObject textConverterUI;
    public GameObject callUI;

    public void StartTextConverter()
    {
        startButton.SetActive(false);
        textConverterUI.SetActive(true);
    }

    public void EndTextConverter()
    {
        startButton.SetActive(true);
        textConverterUI.SetActive(false);
    }

    public void ActivateCallUI()
    {
        callUI.SetActive(true);
    }
}


using UdonSharp;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PanelDigitalClock : UdonSharpBehaviour
{
    [SerializeField]
    Text text1;
    [SerializeField]
    Text text2;

    void Update()
    {
        if (text1.text != DateTime.Now.ToString("HH:mm")) text1.text = DateTime.Now.ToString("HH:mm");
        if (text2.text != DateTime.Now.ToString("yyyy MM/dd")) text2.text = DateTime.Now.ToString("yyyy MM/dd");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMenu : MonoBehaviour
{
    GameObject button1;

    private void Start()
    {
        button1 = GameObject.Find("Button1");
    }
}

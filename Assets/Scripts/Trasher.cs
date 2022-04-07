using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasher : MonoBehaviour
{
    int value = 0;
    TextMesh displayerObj;

    void Start() 
    {
        displayerObj = GameObject.Find("Displayer").GetComponent<TextMesh>();
    }
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "Car")
        {
            value += 50;
            displayerObj.text = "Carbon " + value;
        }

        if (other.gameObject.name == "Plane")
        {
            Debug.Log("Trasher was hit");
            value += 100;
            displayerObj.text = "Carbon " + value;
        }

        if (other.gameObject.name == "Laptop")
        {
            value += 10;
            displayerObj.text = "Carbon " + value;
        }
    }

   
}

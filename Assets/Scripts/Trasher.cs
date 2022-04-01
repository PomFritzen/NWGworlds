using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasher : MonoBehaviour
{
    int value = 0;
    private void OnTriggerEnter(Collider other)
    {
        TextMesh displayerObj = GameObject.Find("Displayer").GetComponent<TextMesh>();
        if (other.gameObject.Equals("Car"))
        {
            value += 50;
            displayerObj.text = "Carbon" + value;
        }

        if (other.gameObject.Equals("Plane"))
        {
            value += 100;
            displayerObj.text = "Carbon" + value;
        }

        if (other.gameObject.Equals("Laptop"))
        {
            value += 10;
            displayerObj.text = "Carbon" + value;
        }
    }
}

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
        
        if (other.gameObject.Equals("Car"))
        {
            value += 50;
            displayerObj.text = "Carbon" + value;
        }

        if (other.gameObject.Equals("Plane"))
        {
            Debug.Log("Trasher was hit");
            value += 100;
            displayerObj.text = "Carbon" + value;
        }

        if (other.gameObject.Equals("Laptop"))
        {
            value += 10;
            displayerObj.text = "Carbon" + value;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.Equals("Car"))
        {
            value += 50;
            displayerObj.text = "Carbon" + value;
        }

        if (other.gameObject.Equals("Plane"))
        {
            Debug.Log("Trasher was hit");
            value += 100;
            displayerObj.text = "Carbon" + value;
        }

        if (other.gameObject.Equals("Laptop"))
        {
            value += 10;
            displayerObj.text = "Carbon" + value;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals("Car"))
        {
            value += 50;
            displayerObj.text = "Carbon" + value;
        }

        if (collision.gameObject.Equals("Plane"))
        {
            Debug.Log("Trasher was hit");
            value += 100;
            displayerObj.text = "Carbon" + value;
        }

        if (collision.gameObject.Equals("Laptop"))
        {
            value += 10;
            displayerObj.text = "Carbon" + value;
        }
    }
}

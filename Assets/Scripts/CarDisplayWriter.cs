using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarDisplayWriter : MonoBehaviour
{
    TextMeshPro screenMsg;
    // Start is called before the first frame update
    void Start()
    {
        screenMsg = GameObject.Find("CurrentCarSize").GetComponent<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CarHoloCollider")
        {
            string objName = name;
            string t = NameToParse(objName);
            screenMsg.text = t;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "CarHoloCollider")
        {
            screenMsg.text = "None";
        }
    }

    public string NameToParse(string objName)
    {
        if (objName == "SCar")
        {
            return "Small Car";
        }

        if (objName == "MCar")
        {
            return "Medium Car";
        }

        if (objName == "LCar")
        {
            return "Large Car";
        }

        if (objName == "ACar")
        {
            return "Average Car";
        }

        return "None";
    }
}

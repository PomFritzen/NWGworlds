using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UnitWWShift : MonoBehaviour
{
    TextMeshPro unitText;


    // Start is called before the first frame update
    void Start()
    {
        unitText = GameObject.Find("MorkmText").GetComponent<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "MorkmColKM")
        {
            unitText.text = "Kilometers";
        }

        if (other.gameObject.name == "MorkmColM")
        {
            unitText.text = "Miles";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "MorkColKM" || other.gameObject.name == "MorkmColM")
        {
            unitText.text = "Unit";
        }
    }
}

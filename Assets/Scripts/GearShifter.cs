using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GearShifter : MonoBehaviour
{

    TextMeshPro gasolineText;
    TextMeshPro dieselText;
    TextMeshPro hiddenValue;

    // Start is called before the first frame update
    void Start()
    {
        gasolineText = GameObject.Find("TextGas").GetComponent<TextMeshPro>();
        dieselText = GameObject.Find("TextDiesel").GetComponent<TextMeshPro>();
        hiddenValue = GameObject.Find("GearHiddenValue").GetComponent<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other)
    {

        
        
        if (other.gameObject.name == "GSColG")
        {
            gasolineText.color = new Color(255, 0, 0);
            hiddenValue.text = "Gasoline";

        }

        if (other.gameObject.name == "GSColD")
        {
            dieselText.color = new Color(255, 0, 0);
            hiddenValue.text = "Diesel";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "GSColG")
        {
            gasolineText.color = new Color(255, 255, 255);
        }

        if (other.gameObject.name == "GSColD")
        {
            dieselText.color = new Color(255, 255, 255);
        }
    }
}

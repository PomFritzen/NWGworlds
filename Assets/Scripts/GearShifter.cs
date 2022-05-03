using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GearShifter : MonoBehaviour
{

    TextMeshPro gasolineText;
    TextMeshPro dieselText;

    // Start is called before the first frame update
    void Start()
    {
        gasolineText = GameObject.Find("TextGas").GetComponent<TextMeshPro>();
        dieselText = GameObject.Find("TextDiesel").GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        
        
        if (other.gameObject.name == "GSColG")
        {
            gasolineText.color = new Color(255, 0, 0);
        }

        if (other.gameObject.name == "GSColD")
        {
            dieselText.color = new Color(255, 0, 0);
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

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FuelLeverScript : MonoBehaviour
{
    TextMeshPro fuelText;

    // Start is called before the first frame update
    void Start()
    {
        fuelText = GameObject.Find("FuelTypeText").GetComponent<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other)
    {
        string col = "Col";
        if (other.gameObject.name == col+"Diesel")
        {
            fuelText.text = "Diesel";
        }

        if (other.gameObject.name == col + "Petrol")
        {
            fuelText.text = "Petrol";
        }

        if (other.gameObject.name == col + "Hybrid")
        {
            fuelText.text = "Hybrid";
        }

        if (other.gameObject.name == col + "CNG")
        {
            fuelText.text = "CNG";
        }

        if (other.gameObject.name == col + "LPG")
        {
            fuelText.text = "LPG";
        }

        if (other.gameObject.name == col + "Unk")
        {
            fuelText.text = "Unknown";
        }

        if (other.gameObject.name == col + "PlugHyb")
        {
            fuelText.text = "Plugin Hybrid";
        }

        if (other.gameObject.name == col + "BatElec")
        {
            fuelText.text = "Battery Electric";
        }


    }

    private void OnTriggerExit(Collider other)
    {
        fuelText.text = "None";
    }
}

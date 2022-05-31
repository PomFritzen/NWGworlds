using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KnobFuel : MonoBehaviour
{

    TextMeshPro fuelText;

    // Start is called before the first frame update
    void Start()
    {
        fuelText = GameObject.Find("CurrentUnit").GetComponent<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other)
    {
        string col = "KnobCol";

        if (other.gameObject.name == col + "Tonnes")
        {
            fuelText.text = "Tonnes";
            Debug.Log("HIT");
        }

        if (other.gameObject.name == col+"Litres")
        {
            fuelText.text = "Litres";
        }

        if (other.gameObject.name == col+"KWH")
        {
            fuelText.text = "kWh";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        string col = "KnobCol";

        if (collision.gameObject.name == col + "Tonnes")
        {
            fuelText.text = "Tonnes";
            Debug.Log("HIT");
        }

        if (collision.gameObject.name == col + "Litres")
        {
            fuelText.text = "Litres";
        }

        if (collision.gameObject.name == col + "KWH")
        {
            fuelText.text = "kWh";
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    fuelText.text = "None";
    //}
}

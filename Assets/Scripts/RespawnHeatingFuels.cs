using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RespawnHeatingFuels : MonoBehaviour
{
    GameObject spawnpoint;
    Rigidbody rbody;
    HeatinCalc hc;

    // Start is called before the first frame update
    void Start()
    {
        hc = new HeatinCalc();
        string fuelName = name;
        string s = "Spawn";
        if (name == "FuelGas")
        {
            spawnpoint = GameObject.Find(s + "1");
        }

        if (name == "FuelOil")
        {
            spawnpoint = GameObject.Find(s + "2");
        }

        if (name == "FuelCoal")
        {
            spawnpoint = GameObject.Find(s + "3");
        }

        if (name == "FuelLPG")
        {
            spawnpoint = GameObject.Find(s + "4");
        }

        if (name == "FuelPropane")
        {
            spawnpoint = GameObject.Find(s + "5");
        }


        if (name == "FuelDiesel")
        {
            spawnpoint = GameObject.Find(s + "6");
        }

        rbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "OvenCol")
        {
            rbody.velocity = Vector3.zero;
            rbody.angularVelocity = Vector3.zero;
            transform.position = spawnpoint.transform.position;

            string unit = GameObject.Find("CurrentUnit").GetComponent<TextMeshPro>().text;
            string mText = GameObject.Find("multiValue").GetComponent<TextMeshPro>().text;
            Debug.Log(mText);
            int multiplier = Int32.Parse(mText);
            hc.UpdateText(name, unit, multiplier);

        }
    }
}

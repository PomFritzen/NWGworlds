using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WheelHornSubmit : MonoBehaviour
{
    public void SubmitInfo()
    {
        bool fuelType = true;
        bool morkm = true;
        int carAmount;
        int efficiency;
        int distance;

        string fuelString = GameObject.Find("GearHiddenValue").GetComponent<TextMeshPro>().text;
        string morkmString = GameObject.Find("MorkmText").GetComponent<TextMeshPro>().text;

        if (fuelString == "Diesel")
        {
            fuelType = true;
        }

        if (fuelString == "Gasoline")
        {
            fuelType = false;
        }

        if (morkmString == "Kilometers")
        {
            morkm = true;
        }

        if (morkmString == "Miles")
        {
            morkm = false;
        }

        carAmount = Int32.Parse(GameObject.Find("CarAmountValue").GetComponent<TextMeshPro>().text);
        efficiency = Int32.Parse(GameObject.Find("EFTotalValue").GetComponent<TextMeshPro>().text);
        distance = Int32.Parse(GameObject.Find("DistanceTotalValue").GetComponent<TextMeshPro>().text);


        double kgco2 = CalculationFunctions.CompanyVehiclesKnownEfficiency(fuelType, morkm, carAmount, efficiency, distance);

        string kgco2text = GameObject.Find("KgCo2Value").GetComponent<TextMeshPro>().text;
        double kgco2CurrentValue = Double.Parse(kgco2text);
        double kgco2NewValue = kgco2CurrentValue += kgco2;

        GameObject.Find("KgCo2Value").GetComponent<TextMeshPro>().text = "" + kgco2NewValue;

        UpdateSpeed(kgco2NewValue);
    }

    public void UpdateSpeed(double val)
    {
        int newSpeed = (int)Math.Round(val);
        GameObject.Find("RoadOn").GetComponent<RoadMovement>().speed = newSpeed;
        GameObject.Find("RoadInFront").GetComponent<RoadMovement>().speed = newSpeed;
        GameObject.Find("RoadInBack").GetComponent<RoadMovement>().speed = newSpeed;
        
    }
}

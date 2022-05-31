using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeatinCalc : MonoBehaviour
{

    TextMeshPro amountTMP;
    public void UpdateText(string fuelName, string unit, int multiplier)
    {
        amountTMP = GameObject.Find("AmountText").GetComponent<TextMeshPro>();

        double kgCo2 = 0.0;

        if (fuelName == "FuelGas")
        {
            if (unit == "Tonnes")
            {
                kgCo2 = 2538.48;
            }

            else if (unit == "Litres")
            {
                //Here
                kgCo2 = 2.022135;
            }

            else if (unit == "kWh")
            {
                kgCo2 = 0.1832;
            }
        }

        if (fuelName == "FuelOil")
        {
            if (unit == "Tonnes")
            {
                kgCo2 = 3165.01;
            }

            else if (unit == "Litres")
            {
                kgCo2 = 2.5401;
            }

            else if (unit == "kWh")
            {
                kgCo2 = 0.2468;
            }
        }

        if (fuelName == "FuelCoal")
        {
            if (unit == "Tonnes")
            {
                kgCo2 = 2883.26;
            }

            else if (unit == "Litres")
            {
                //Here
                kgCo2 = 2883.26;
            }

            else if (unit == "kWh")
            {
                kgCo2 = 0.3446;
            }
        }

        if (fuelName == "FuelLPG")
        {
            if (unit == "Tonnes")
            {
                kgCo2 = 2939.29;
            }

            else if (unit == "Litres")
            {
                //Here
                kgCo2 = 155709;
            }

            else if (unit == "kWh")
            {
                kgCo2 = 21449;
            }
        }

        if (fuelName == "FuelPropane")
        {
            if (unit == "Tonnes")
            {
                kgCo2 = 2997.55;
            }

            else if (unit == "Litres")
            {
                //Here
                kgCo2 = 1.5435;
            }

            else if (unit == "kWh")
            {
                kgCo2 = 0.2141;
            }
        }

        if (fuelName == "FuelDiesel")
        {
            if (unit == "Tonnes")
            {
                kgCo2 = 2969.07;
            }

            else if (unit == "Litres")
            {
                //Here
                kgCo2 = 2.5123;
            }

            else if (unit == "kWh")
            {
                kgCo2 = 0.2369;
            }
        }

        double total = kgCo2 * (double)multiplier;
        string currentText = amountTMP.text;
        string[] split = currentText.Split(':');
        double currentAmount = Convert.ToDouble(split[1]);
        double newAmount = currentAmount += total;
        amountTMP.text = "Amount: " + newAmount;

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SubmitCarButton : MonoBehaviour
{
    [SerializeField]
    private CurrentCarInformation car;
    GameObject obj;
    CarSpawn cs;

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("CurrentCarObj").GetComponent<CurrentCarInformation>();
        cs = new CarSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        car = GameObject.Find("CurrentCarObj").GetComponent<CurrentCarInformation>();
    }

    public void UpdateScreen()
    {
        car = GameObject.Find("CurrentCarObj").GetComponent<CurrentCarInformation>();
        int singlesMultiplier = Int32.Parse(GameObject.Find("SinglesNums").GetComponent<TextMeshPro>().text);
        int tensMultiplier = Int32.Parse(GameObject.Find("TensNums").GetComponent<TextMeshPro>().text);
        int totalMultiplier = singlesMultiplier * tensMultiplier;

        if (car.fuelType == "Plugin Hybrid")
        {
            car.fuelType = "PluginHybrid";
        }

        if (car.fuelType == "Battery Electric")
        {
            car.fuelType = "BatteryElectric";
        }

        double initialValue = CalculationFunctions.CalcCO2FromCar(car);
        double value = initialValue * totalMultiplier;

        string objname = "";
        string buildStr1 = "";
        string buildStr2 = car.fuelType;

        Debug.Log("buildstr2 is: " + buildStr2);

        

        if (car.carSize == "SmallCar")
        {
            buildStr1 = "SC";
        }

        if (car.carSize == "MediumCar")
        {
            buildStr1 = "MC";
        }

        if (car.carSize == "LargeCar")
        {
            buildStr1 = "LC";
        }

        if (car.carSize == "AverageCar")
        {
            buildStr1 = "AC";
        }

        objname = buildStr1 + buildStr2 + "T";
        string objname2 = "F" + buildStr2 + "T";

        //Increase amount
        TextMeshPro amountDisplayText = GameObject.Find(objname).GetComponent<TextMeshPro>();
        int oldAmount = Int32.Parse(amountDisplayText.text);
        int newAmount = oldAmount += totalMultiplier;
        amountDisplayText.text = "" + newAmount;

        //Increase fuel
        TextMeshPro fuelDisplayText = GameObject.Find(objname2).GetComponent<TextMeshPro>();
        string currentStr = fuelDisplayText.text;
        string[] splitStr = currentStr.Split('k');
        double oldVal = Double.Parse(splitStr[0]);
        double newVal = oldVal += value;
        fuelDisplayText.text = "" + newVal + "kg";

        //Increase total amount
        TextMeshPro totalAmount = GameObject.Find("TC"+buildStr2+"T").GetComponent<TextMeshPro>();
        int prevTotal = Int32.Parse(totalAmount.text);
        int newTotal = prevTotal += totalMultiplier;
        totalAmount.text = "" + newTotal;

        //Increase total fuel
        TextMeshPro totalFuel = GameObject.Find("FTotalT").GetComponent<TextMeshPro>();
        string totalCurrentFuel = totalFuel.text;
        string[] tcfSplit = totalCurrentFuel.Split('k');
        double prevFuel = Double.Parse(tcfSplit[0]);
        double newFuel = prevFuel + value;
        totalFuel.text = "" + newFuel+"kg";

        cs.SpawnCar(car, totalMultiplier);
    }
}

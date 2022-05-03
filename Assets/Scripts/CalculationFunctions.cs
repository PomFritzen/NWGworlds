using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class CalculationFunctions
{

    public static ArrayList CarInformation()
    {
        Debug.Log("We are in car information");

        string startPath = Application.dataPath;
        Debug.Log(startPath);
        string[] info = File.ReadAllLines(startPath + "/TextFiles/info.txt");
        ArrayList carInfos = new ArrayList();

        for (int i = 0; i < info.Length; i++)
        {
            string current = info[i];
            string[] split = current.Split(' ');
            carInfo car = new carInfo();
            car.fuelName = split[0];
            car.size = split[1];
            car.milesOrKm = split[2];
            string toParse = split[3].Replace('.', ',');
            car.value = Double.Parse(toParse);
            carInfos.Add(car);
        }

        return carInfos;
        
    }

    public class carInfo
    {
        public string milesOrKm;
        public string size;
        public string fuelName;
        public double value;
    }

    //Scope 1
    public static double Heating(int unit, int ef, int amount)
    {
        double result = 0.0;
        return result;
    }

    public static double Refrigirants(int unit, int ef, int amount)
    {
        double result = 0.0;
        return result;
    }

    //kgPr is kgCO2e per litre for km calculations and is kg CO2 per gallon for miles calculations
    public static double CompanyVehiclesKnownEfficiency(bool milesOrKilometers, double efficiency, int distance, double kgPr)
    {
        //true = kilometers
        if (milesOrKilometers)
        {
            double result = (efficiency / 100) * distance * (kgPr / 1000);
            return result;
        }

        //false = miles
        if (!milesOrKilometers)
        {
            double result = distance / efficiency * kgPr / 1000;
            return result;
        }

        return 0.0;
    }

    public static double CalcCO2FromCar(CurrentCarInformation car)
    {
        Debug.Log("We are in calc car");
        double valueToReturn = 0.0;
        //Remove space
        string[] split = car.carSize.Split(' ');
        car.carSize = "" + split[0] + split[1];

        ArrayList carInfos = CarInformation();

        for (int i = 0; i < carInfos.Count; i++)
        {
            carInfo currentCar = (carInfo)carInfos[i];
            if (currentCar.fuelName == car.fuelType && currentCar.size == car.carSize && currentCar.milesOrKm == car.milesOrKm)
            {
                valueToReturn = currentCar.value;
            }
        }

        return valueToReturn;
    }

    public static double CompanyVehiclesUnknownEfficiency(bool milesOrKilometers, ArrayList allCarsAndCartypes)
    {
        ArrayList DieselCars = new ArrayList();
        ArrayList PetrolCars = new ArrayList();
        ArrayList HybridCars = new ArrayList();
        ArrayList CNGCars = new ArrayList();
        ArrayList LPGCars = new ArrayList();
        ArrayList UnknownCars = new ArrayList();
        ArrayList PlugInHybridElectricCars = new ArrayList();
        ArrayList BatteryElectricCars = new ArrayList();

        AddCarsToList(DieselCars, allCarsAndCartypes, 0);
        AddCarsToList(PetrolCars, allCarsAndCartypes, 1);
        AddCarsToList(HybridCars, allCarsAndCartypes, 2);
        AddCarsToList(CNGCars, allCarsAndCartypes, 3);
        AddCarsToList(LPGCars, allCarsAndCartypes, 4);
        AddCarsToList(UnknownCars, allCarsAndCartypes, 5);
        AddCarsToList(PlugInHybridElectricCars, allCarsAndCartypes, 6);
        AddCarsToList(BatteryElectricCars, allCarsAndCartypes, 7);

        if (milesOrKilometers)
        {
            return 0.0;
        }

        if (!milesOrKilometers)
        {
            return 0.0;
        }

        return 0.0;
    }

    public static void AddCarsToList(ArrayList listToAddTo, ArrayList listToAddFrom, int type)
    {
        for (int i = 0; i < listToAddFrom.Count; i++)
        {
            CarType car = (CarType)listToAddFrom[i];

            if (car.type == type)
            {
                listToAddTo.Add(car);
            }

        }
    }

    //Scope 2

    public static double ElectricityTotal(ArrayList arrList)
    {
        double result = 0.0;
        for (int i = 0; i < arrList.Count; i++)
        {
            result += (double)arrList[i];
        }

        return result;
    }



    //Scope 3

    
}

class CarType
{
    public int carSize;
    public int type;
}

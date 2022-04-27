using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculationFunctions : MonoBehaviour
{
    //Scope 1
    public double Heating(int unit, int ef, int amount)
    {
        double result = 0.0;
        return result;
    }

    public double Refrigirants(int unit, int ef, int amount)
    {
        double result = 0.0;
        return result;
    }

    //kgPr is kgCO2e per litre for km calculations and is kg CO2 per gallon for miles calculations
    public double CompanyVehiclesKnownEfficiency(bool milesOrKilometers, double efficiency, int distance, double kgPr)
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

    public double CompanyVehiclesUnknownEfficiency(bool milesOrKilometers, ArrayList allCarsAndCartypes)
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

    public void AddCarsToList(ArrayList listToAddTo, ArrayList listToAddFrom, int type)
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

    public double ElectricityTotal(ArrayList arrList)
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

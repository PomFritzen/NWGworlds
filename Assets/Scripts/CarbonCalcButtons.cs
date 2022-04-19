using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CarbonCalcButtons : MonoBehaviour
{
    //Displays on result screen
    TextMeshPro allTotal;
    TextMeshPro planeTotal;
    TextMeshPro carTotal;
    TextMeshPro laptopTotal;
    TextMeshPro meatTotal;


    //Displays on calculator
    TextMeshPro planeCounterx1;
    TextMeshPro planeCounterx10;
    TextMeshPro carCounterx1;
    TextMeshPro carCounterx10;
    int[] multiplier;
    ArrayList multiList;

    private void Start()
    {
        allTotal = GameObject.Find("TextCarbonTotalAmount").GetComponent<TextMeshPro>();
        planeTotal = GameObject.Find("TextPlaneTotalAmount").GetComponent<TextMeshPro>();
        carTotal = GameObject.Find("TextCarTotalAmount").GetComponent<TextMeshPro>();
        laptopTotal = GameObject.Find("TextLaptopTotalAmount").GetComponent<TextMeshPro>();
        meatTotal = GameObject.Find("TextMeatTotalAmount").GetComponent<TextMeshPro>();
        
        planeCounterx1 = GameObject.Find("PlaneDisplayTextx1").GetComponent<TextMeshPro>();
        planeCounterx10 = GameObject.Find("PlaneDisplayTextx10").GetComponent<TextMeshPro>();

        carCounterx1 = GameObject.Find("CarDisplayTextx1").GetComponent<TextMeshPro>();
        carCounterx10 = GameObject.Find("CarDisplayTextx10").GetComponent<TextMeshPro>();

        multiplier = new int[] { 1, 10, 100, 1000, 10000, 100000 };
        multiList = new ArrayList();
        for (int i = 0; i < multiplier.Length; i++)
        {
            multiList.Add(multiplier[i]);
        }
    }

    public int GetIntValue(string strToUse)
    {
        int value = Int32.Parse(strToUse);
        return value;
    }

    public void PlaneX1L()
    {
        int valToDecrease = GetIntValue(planeCounterx1.text);
        int newVal;
        if (valToDecrease == 1)
        {
            newVal = 9;
        } else
        {
            newVal = valToDecrease -= 1;
        }

        string newStr = "" + newVal;
        planeCounterx1.text = newStr;
    }

    public void PlaneX1R()
    {
        int valToIncrease = GetIntValue(planeCounterx1.text);
        int newVal;
        if (valToIncrease == 9)
        {
            newVal = 1;
        } else
        {
            newVal = valToIncrease += 1;
        }
        string newStr = "" + newVal;
        planeCounterx1.text = newStr;
    }

    public void CarX1L()
    {
        int valToDecrease = GetIntValue(carCounterx1.text);
        int newVal;
        if (valToDecrease == 1)
        {
            newVal = 9;
        }
        else
        {
            newVal = valToDecrease -= 1;
        }

        string newStr = "" + newVal;
        carCounterx1.text = newStr;
    }

    public void CarX1R()
    {
        int valToIncrease = GetIntValue(carCounterx1.text);
        int newVal;
        if (valToIncrease == 9)
        {
            newVal = 1;
        }
        else
        {
            newVal = valToIncrease += 1;
        }
        string newStr = "" + newVal;
        carCounterx1.text = newStr;
    }

    public void PlaneX10L()
    {
        int valToDecrease = GetIntValue(planeCounterx10.text);
        int listIndex = multiList.IndexOf(valToDecrease);
        int lastIndex = multiList.Count - 1;
        int newVal;
        if (listIndex == 0)
        {
            newVal = (int)multiList[lastIndex];
        } else
        {
            newVal = (int)multiList[listIndex - 1];
        }
        string newStr = "" + newVal;
        planeCounterx10.text = newStr;
    }

    public void CarX10L()
    {
        int valToDecrease = GetIntValue(carCounterx10.text);
        int listIndex = multiList.IndexOf(valToDecrease);
        int lastIndex = multiList.Count - 1;
        int newVal;
        if (listIndex == 0)
        {
            newVal = (int)multiList[lastIndex];
        }
        else
        {
            newVal = (int)multiList[listIndex - 1];
        }
        string newStr = "" + newVal;
        carCounterx10.text = newStr;
    }

    public void CarX10R()
    {
        int valToIncrease = GetIntValue(carCounterx10.text);
        int listIndex = multiList.IndexOf(valToIncrease);
        int lastIndex = multiList.Count - 1;
        int newVal;
        if (listIndex == lastIndex)
        {
            newVal = (int)multiList[0];
        }
        else
        {
            newVal = (int)multiList[listIndex + 1];
        }
        string newStr = "" + newVal;
        carCounterx10.text = newStr;
    }

    public void PlaneX10R()
    {
        int valToIncrease = GetIntValue(planeCounterx10.text);
        int listIndex = multiList.IndexOf(valToIncrease);
        int lastIndex = multiList.Count - 1;
        int newVal;
        if (listIndex == lastIndex)
        {
            newVal = (int)multiList[0];
        } else
        {
            newVal = (int)multiList[listIndex + 1];
        }
        string newStr = "" + newVal;
        planeCounterx10.text = newStr;
    }

    public void PlaneSubmit()
    {
        int val1 = GetIntValue(planeCounterx1.text);
        int val2 = GetIntValue(planeCounterx10.text);
        int product = val1 * val2;
        Console.WriteLine("product is: "+product);
        int currentTotalVal = GetIntValue(planeTotal.text);
        int newTotalVal = currentTotalVal + product;
        Console.WriteLine("newTotalVal is: " + newTotalVal);
        string newStr = "" + newTotalVal;
        planeTotal.text = newStr;
        UpdateTotal(product);
        PlaneReset();
    }

    public void PlaneReset()
    {
        planeCounterx1.text = "1";
        planeCounterx10.text = "1";
    }

    public void CarReset()
    {
        carCounterx1.text = "1";
        carCounterx10.text = "1";
    }

    public void CarSubmit()
    {
        int val1 = GetIntValue(carCounterx1.text);
        int val2 = GetIntValue(carCounterx10.text);
        int product = val1 * val2;
        Console.WriteLine("product is: " + product);
        int currentTotalVal = GetIntValue(carTotal.text);
        int newTotalVal = currentTotalVal + product;
        Console.WriteLine("newTotalVal is: " + newTotalVal);
        string newStr = "" + newTotalVal;
        carTotal.text = newStr;
        UpdateTotal(product);
        CarReset();
    }

    public void UpdateTotal(int valueToUpdateWith)
    {
        int totalVal = GetIntValue(allTotal.text);
        int newVal = totalVal += valueToUpdateWith;
        allTotal.text = "" + newVal;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ElectricityButtons : MonoBehaviour
{

    public ArrayList ActiveList(string activeCountry)
    {
        if (activeCountry == "Asia")
        {
            return GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().asia;
        }

        if (activeCountry == "Africa")
        {
            return GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().africa;
        }

        if (activeCountry == "AustraliaOceana")
        {
            return GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().australiaOceana;
        }

        if (activeCountry == "Europe")
        {
            return GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().europe;
        }

        if (activeCountry == "NorthAmerica")
        {
            return GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().northAmerica;
        }

        if (activeCountry == "SouthAmerica")
        {
            return GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().southAmerica;
        }

        return GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().southAmerica;
    }

    public void GoUp()
    {
        int currentNum = GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField;

        string activeCountry = GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().activeCountry;
        ArrayList currentList = ActiveList(activeCountry);

        if (currentNum+1 > currentList.Count)
        {
            currentNum = 0;
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField = currentNum;
            GameObject.Find("InputFieldObj(Clone)" + GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField).GetComponentInChildren<TextMeshPro>().color = new Color(1, 1, 1);
        } else
        {
            currentNum += 1;
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField += 1;
            GameObject.Find("InputFieldObj(Clone)" + GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField).GetComponentInChildren<TextMeshPro>().color = new Color(1, 1, 1);
        }
    }

    public void GoDown()
    {

        int currentNum = GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField;

        string activeCountry = GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().activeCountry;
        ArrayList currentList = ActiveList(activeCountry);

        if (currentNum - 1 < 0)
        {
            currentNum = currentList.Count-1;
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField = currentNum;
            GameObject.Find("InputFieldObj(Clone)" + GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField).GetComponentInChildren<TextMeshPro>().color = new Color(1, 1, 1);
        }
        else
        {
            currentNum -= 1;
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField -= 1;
            GameObject.Find("InputFieldObj(Clone)" + GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField).GetComponentInChildren<TextMeshPro>().color = new Color(1, 1, 1);   
        }
    }

    public void AddValue()
    {
        int value = (int)Char.GetNumericValue(transform.parent.name[name.Length - 1]);
        GameObject currentField = GameObject.Find("InputFieldObj(Clone)" + GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField);
        string currentText = currentField.GetComponentInChildren<TextMeshPro>().text;
        string newText = currentText + value;
        GameObject.Find("InputFieldObj(Clone)" + GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField).GetComponentInChildren<TextMeshPro>().text = newText;

        AddValueCVDArrayList(Int32.Parse(newText));
        TotalElec te = new TotalElec();
        te.CalcElecTotal();
    }

    public void RemoveValue()
    {
        GameObject currentField = GameObject.Find("InputFieldObj(Clone)" + GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField);
        string currentText = currentField.GetComponentInChildren<TextMeshPro>().text;
        string newText = currentText.Remove(currentText.Length - 1);
        GameObject.Find("InputFieldObj(Clone)" + GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField).GetComponentInChildren<TextMeshPro>().text = newText;

        AddValueCVDArrayList(Int32.Parse(newText));
        TotalElec te = new TotalElec();
        te.CalcElecTotal();
    }

    public void ResetValue()
    {
        GameObject currentField = GameObject.Find("InputFieldObj(Clone)" + GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField);
        string currentText = currentField.GetComponentInChildren<TextMeshPro>().text;
        string newText = "0";
        GameObject.Find("InputFieldObj(Clone)" + GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField).GetComponentInChildren<TextMeshPro>().text = newText;

        AddValueCVDArrayList(Int32.Parse(newText));
    }

    public void AddValueCVDArrayList(int value)
    {
        int pos = GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField;
        string country = GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().activeCountry;

        if (country == "Asia")
        {
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().asia[pos] = value;
        }

        if (country == "Africa")
        {
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().africa[pos] = value;
        }

        if (country == "AustraliaOceana")
        {
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().australiaOceana[pos] = value;
        }

        if (country == "Europe")
        {
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().europe[pos] = value;
        }

        if (country == "NorthAmerica")
        {
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().northAmerica[pos] = value;
        }

        if (country == "SouthAmerica")
        {
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().southAmerica[pos] = value;
        }

    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class ContinentCountries : MonoBehaviour
{

    public void GetContinentCountries(string continent)
    {
        ArrayList countries = new ArrayList();
        TextMeshPro displayText = GameObject.Find("CountryListText").GetComponent<TextMeshPro>();

        string startPath = Application.dataPath;
        string textsPath = startPath + "/TextFiles/Electricity/";

        string[] list = File.ReadAllLines(textsPath + continent);

        for (int i = 0; i < list.Length; i++)
        {
            string[] currentLine = list[i].Split(' ');
            string country = currentLine[0];
            double val = Double.Parse(currentLine[1]);
            countries.Add(country);
        }

        string listOfCountries = StringBuilder(countries);

        displayText.text = listOfCountries;
        //CreateInputFields(countries.Count);
        DestroyPreviousFields();
        GameObject.Find("FieldDestroyer").GetComponent<ContinentFieldDestroyer>().shouldDestroy = false;
        string cont = GetContinentForInputFields(continent);
        CreateInputFields(cont);

    }

    public string StringBuilder(ArrayList arrList)
    {

        string complete = "";

        for (int i = 0; i < arrList.Count; i++)
        {
            complete += arrList[i] + " \n";
        }

        return complete;
    }

    /*
    public void CreateInputFields(int amount)
    {
        GameObject objToClone = GameObject.Find("InputFieldObj").GetComponent<GameObject>();
        float startYValue = GameObject.Find("InputFieldPos").GetComponentInChildren<GameObject>().transform.position.y;
        float yVal = startYValue;
        for (int i = 0; i < amount; i++)
        {
            Instantiate(objToClone, new Vector3(objToClone.transform.position.x, yVal, objToClone.transform.position.z), Quaternion.identity);
            yVal -= 0.121f;
        }
    }
    */

    public void DestroyPreviousFields()
    {
        GameObject.Find("FieldDestroyer").GetComponent<ContinentFieldDestroyer>().shouldDestroy = true;
    }

    public string GetContinentForInputFields(string continent)
    {

        if (continent == "AfricaList.txt")
        {
            return "Africa";
        }

        if (continent == "AsiaList.txt")
        {
            return "Asia";
        }

        if (continent == "AusOceList.txt")
        {
            return "AustraliaOceana";
        }

        if (continent == "EuropeList.txt")
        {
            return "Europe";
        }

        if (continent == "NAmericaList.txt")
        {
            return "NorthAmerica";
        }

        if (continent == "SAmericaList.txt")
        {
            return "SouthAmerica";
        }

        return "";
    }

    public void CreateInputFields(string cont)
    {
        GameObject valueContainer = GameObject.Find("ListValueContainer");

        GameObject objToClone = GameObject.Find("InputFieldObj");
        Vector3 startPos = GameObject.Find("InputFieldPos").transform.position;
        float yVal = startPos.y;

        if (cont == "Asia")
        {
            int amt = valueContainer.GetComponent<ContinentValueDisplays>().asia.Count;

            for (int i = 0; i < amt; i++)
            {
                GameObject clone = Instantiate(objToClone, new Vector3(startPos.x, yVal, startPos.z), Quaternion.identity);
                clone.GetComponent<TextMeshPro>().text = valueContainer.GetComponent<ContinentValueDisplays>().asia[i].ToString();
                yVal -= 0.082f;
                clone.name = clone.name + i;
            }
        }

        if (cont == "Africa")
        {
            int amt = valueContainer.GetComponent<ContinentValueDisplays>().africa.Count;

            for (int i = 0; i < amt; i++)
            {
                GameObject clone = Instantiate(objToClone, new Vector3(startPos.x, yVal, startPos.z), Quaternion.identity);
                clone.GetComponent<TextMeshPro>().text = valueContainer.GetComponent<ContinentValueDisplays>().africa[i].ToString();
                yVal -= 0.082f;
                clone.name = clone.name + i;
            }
        }

        if (cont == "AustraliaOceana")
        {
            int amt = valueContainer.GetComponent<ContinentValueDisplays>().australiaOceana.Count;

            for (int i = 0; i < amt; i++)
            {
                GameObject clone = Instantiate(objToClone, new Vector3(startPos.x, yVal, startPos.z), Quaternion.identity);
                clone.GetComponentInChildren<TextMeshPro>().text = valueContainer.GetComponent<ContinentValueDisplays>().australiaOceana[i].ToString();
                yVal -= 0.082f;
                clone.name = clone.name + i;
            }
        }

        if (cont == "Europe")
        {
            int amt = valueContainer.GetComponent<ContinentValueDisplays>().europe.Count;

            for (int i = 0; i < amt; i++)
            {
                GameObject clone = Instantiate(objToClone, new Vector3(startPos.x, yVal, startPos.z), Quaternion.identity);
                clone.GetComponent<TextMeshPro>().text = valueContainer.GetComponent<ContinentValueDisplays>().europe[i].ToString();
                yVal -= 0.082f;
                clone.name = clone.name + i;
            }
        }

        if (cont == "NorthAmerica")
        {
            int amt = valueContainer.GetComponent<ContinentValueDisplays>().northAmerica.Count;

            for (int i = 0; i < amt; i++)
            {
                GameObject clone = Instantiate(objToClone, new Vector3(startPos.x, yVal, startPos.z), Quaternion.identity);
                clone.GetComponent<TextMeshPro>().text = valueContainer.GetComponent<ContinentValueDisplays>().northAmerica[i].ToString();
                yVal -= 0.082f;
                clone.name = clone.name + i;
            }
        }

        if (cont == "SouthAmerica")
        {
            int amt = valueContainer.GetComponent<ContinentValueDisplays>().southAmerica.Count;

            for (int i = 0; i < amt; i++)
            {
                GameObject clone = Instantiate(objToClone, new Vector3(startPos.x, yVal, startPos.z), Quaternion.identity);
                clone.GetComponent<TextMeshPro>().text = valueContainer.GetComponent<ContinentValueDisplays>().southAmerica[i].ToString();
                yVal -= 0.082f;
                clone.name = clone.name + i;
            }
        }

    }
}

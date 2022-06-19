using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentCarInformation : MonoBehaviour
{
    public string milesOrKm;
    public int singlesData;
    public int tensData;
    public string carSize;
    public string fuelType;

    private void Start()
    {
        milesOrKm = GameObject.Find("morkmNums").GetComponent<TextMeshPro>().text;
        singlesData = Int32.Parse(GameObject.Find("SinglesNums").GetComponent<TextMeshPro>().text);
        tensData = Int32.Parse(GameObject.Find("TensNums").GetComponent<TextMeshPro>().text);
        carSize = GameObject.Find("CurrentCarSize").GetComponent<TextMeshPro>().text;
        fuelType = GameObject.Find("FuelTypeText").GetComponent<TextMeshPro>().text;
    }

    private void Update()
    {
        milesOrKm = GameObject.Find("morkmNums").GetComponent<TextMeshPro>().text;
        singlesData = Int32.Parse(GameObject.Find("SinglesNums").GetComponent<TextMeshPro>().text);
        tensData = Int32.Parse(GameObject.Find("TensNums").GetComponent<TextMeshPro>().text);
        carSize = GameObject.Find("CurrentCarSize").GetComponent<TextMeshPro>().text;
        fuelType = GameObject.Find("FuelTypeText").GetComponent<TextMeshPro>().text;
    }

    public int GetSinglesData()
    {
        return singlesData;
    }
}

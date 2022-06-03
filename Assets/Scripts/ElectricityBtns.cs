using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ElectricityBtns : MonoBehaviour
{

    public void DeleteLetter()
    {
        TextMeshPro countryInput = GameObject.Find("CountryInputText").GetComponent<TextMeshPro>();
        string currStr = countryInput.text;
        string newStr = currStr.Remove(currStr.Length - 1);
        countryInput.text = newStr;
    }

    public void AddLetter()
    {
        
        TextMeshPro thisLetterObj = GetComponentInChildren<TextMeshPro>();
        string thisLetter = thisLetterObj.text;
        TextMeshPro countryInput = GameObject.Find("CountryInputText").GetComponent<TextMeshPro>();
        string currStr = countryInput.text;
        string newStr = currStr + thisLetter;
        countryInput.text = newStr;

    }

}

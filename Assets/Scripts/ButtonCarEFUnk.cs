using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonCarEFUnk : MonoBehaviour
{

    TextMeshPro singlesDisplay;
    TextMeshPro tensDisplay;
    int[] multiplier;
    ArrayList multiList;

    // Start is called before the first frame update
    void Start()
    {
        multiplier = new int[] { 1, 10, 100, 1000, 10000, 100000 };
        multiList = new ArrayList();
        for (int i = 0; i < multiplier.Length; i++)
        {
            multiList.Add(multiplier[i]);
        }
        singlesDisplay = GameObject.Find("SinglesNums").GetComponent<TextMeshPro>();
        tensDisplay = GameObject.Find("TensNums").GetComponent<TextMeshPro>();
    }

    public int GetIntValue(string strToUse)
    {
        int value = Int32.Parse(strToUse);
        return value;
    }

    public void IncreaseSingles()
    {
        int valToIncrease = GetIntValue(singlesDisplay.text);
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
        singlesDisplay.text = newStr;
    }

    public void DecreaseSingles()
    {
        int valToDecrease = GetIntValue(singlesDisplay.text);
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
        singlesDisplay.text = newStr;
    }

    public void IncreaseTens()
    {
        int valToIncrease = GetIntValue(tensDisplay.text);
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
        tensDisplay.text = newStr;
    }

    public void DecreaseTens()
    {
        int valToDecrease = GetIntValue(tensDisplay.text);
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
        tensDisplay.text = newStr;
    }

}

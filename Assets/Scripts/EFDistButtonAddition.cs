using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EFDistButtonAddition : MonoBehaviour
{

    TextMeshPro distanceValueText;
    TextMeshPro efficiencyValueText;
    bool efOrDist; //true = ef, false = dist

    // Start is called before the first frame update
    void Start()
    {
        distanceValueText = GameObject.Find("DistanceTotalValue").GetComponent<TextMeshPro>();
        efficiencyValueText = GameObject.Find("EFTotalValue").GetComponent<TextMeshPro>();
    }

    private void Update()
    {
        string current = GameObject.Find("EFOrDistText").GetComponent<TextMeshPro>().text;

        if (current == "Efficiency")
        {
            efOrDist = true;
        }

        if (current == "Distance")
        {
            efOrDist = false;
        }
    }

    public void AddValue()
    {
        Debug.Log(transform.parent.name);
        int value = (int)Char.GetNumericValue(transform.parent.name[name.Length - 1]);
        Debug.Log(value);

        string currentValueText = "";

        if (efOrDist == true)
        {
            currentValueText = efficiencyValueText.text;
        }

        if (efOrDist == false)
        {
            currentValueText = distanceValueText.text;
        }

        string newValueText = "";

        if (currentValueText != "0")
        {
             newValueText = currentValueText + "" + value;
        }
        else
        {
             newValueText = "" + value;
        }
        

        if (efOrDist == true)
        {
            efficiencyValueText.text = newValueText;
        }

        if (efOrDist == false)
        {
            distanceValueText.text = newValueText;
        }

    }

    public void RemoveValue()
    {
        if (efOrDist == true)
        {
            efficiencyValueText.text = efficiencyValueText.text.Remove(efficiencyValueText.text.Length - 1, 1);
        }

        if (efOrDist == false)
        {
            distanceValueText.text = distanceValueText.text.Remove(distanceValueText.text.Length - 1, 1);
        }
    }


}

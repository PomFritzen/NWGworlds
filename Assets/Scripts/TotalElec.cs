using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using System;

public class TotalElec : MonoBehaviour
{

    public void CalcElecTotal()
    {
        int africaTotal = 0;

        for (int i = 0; i < GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().africa.Count; i++)
        {
            africaTotal += Int32.Parse(GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().africa[i].ToString());
        }

        int asiaTotal = 0;

        for (int i = 0; i < GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().asia.Count; i++)
        {
            asiaTotal += Int32.Parse(GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().asia[i].ToString());
        }

        int australiaOceanaTotal = 0;

        for (int i = 0; i < GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().australiaOceana.Count; i++)
        {
            australiaOceanaTotal += Int32.Parse(GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().australiaOceana[i].ToString());
        }

        int europeTotal = 0;

        for (int i = 0; i < GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().europe.Count; i++)
        {
            europeTotal += Int32.Parse(GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().europe[i].ToString());
        }

        int northAmericaTotal = 0;

        for (int i = 0; i < GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().northAmerica.Count; i++)
        {
            northAmericaTotal += Int32.Parse(GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().northAmerica[i].ToString());
        }

        int southAmericaTotal = 0;

        for (int i = 0; i < GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().southAmerica.Count; i++)
        {
            southAmericaTotal += Int32.Parse(GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().southAmerica[i].ToString());
        }


        int totalSum = africaTotal + asiaTotal + australiaOceanaTotal + europeTotal + northAmericaTotal + southAmericaTotal;

        GameObject.Find("TotalText").GetComponent<TextMeshPro>().text = totalSum.ToString();
    }

}

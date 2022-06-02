using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SnowBallSubmit : MonoBehaviour
{
    RefrigLister lister;
    NumFigReturnVal multi5;
    NumFigReturnVal multi4;
    NumFigReturnVal multi3;
    NumFigReturnVal multi2;
    NumFigReturnVal multi1;
    TextMeshPro amountText;

    // Start is called before the first frame update
    void Start()
    {
        lister = GameObject.Find("Lister").GetComponent<RefrigLister>();

        multi5 = GameObject.Find("MultiColPos5").GetComponent<NumFigReturnVal>();
        multi4 = GameObject.Find("MultiColPos4").GetComponent<NumFigReturnVal>();
        multi3 = GameObject.Find("MultiColPos3").GetComponent<NumFigReturnVal>();
        multi2 = GameObject.Find("MultiColPos2").GetComponent<NumFigReturnVal>();
        multi1 = GameObject.Find("MultiColPos1").GetComponent<NumFigReturnVal>();

        amountText = GameObject.Find("TotalText").GetComponent<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SubmitHitbox")
        {
            int value = 0;
            int currAct = lister.activitySelector;
            int currEm = lister.emissionSelector;

            if (currAct == 0)
            {
                value = Int32.Parse(lister.kyotoProtocolStandardVals[currEm].ToString());
            }

            if (currAct == 1)
            {
                value = Int32.Parse(lister.kyotoProtocolBlendsVals[currEm].ToString());
            }

            if (currAct == 2)
            {
                value = Int32.Parse(lister.montrealProtocolStandardVals[currEm].ToString());
            }

            if (currAct == 3)
            {
                value = Int32.Parse(lister.montrealProtocolBlendsVals[currEm].ToString());
            }

            if (currAct == 4)
            {
                value = Int32.Parse(lister.otherPerfluorinatedGasesVals[currEm].ToString());
            }

            if (currAct == 5)
            {
                value = Int32.Parse(lister.fluorinatedEthersVals[currEm].ToString());
            }

            if (currAct == 6)
            {
                value = Int32.Parse(lister.otherRefrigirantsVals[currEm].ToString());
            }

            int m5 = multi5.GetValue()*10000;
            int m4 = multi4.GetValue()*1000;
            int m3 = multi3.GetValue()*100;
            int m2 = multi2.GetValue()*10;
            int m1 = multi1.GetValue();

            int multiplier = m5+m4+m3+m2+m1;

            int total = value * multiplier;

            int prevTotal = Int32.Parse(amountText.text);

            int newTotal = total + prevTotal;

            amountText.text = newTotal.ToString();
        }
    }

}

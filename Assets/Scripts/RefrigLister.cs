using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class RefrigLister : MonoBehaviour
{
    //Selectors
    public int activitySelector = 0;
    public int emissionSelector = 0;

    //Texts
    public ArrayList activites = new ArrayList();
    public ArrayList activeEmission = new ArrayList();
    public ArrayList kyotoProtocolStandard = new ArrayList();
    public ArrayList kyotoProtocolBlends = new ArrayList();
    public ArrayList montrealProtocolStandard = new ArrayList();
    public ArrayList montrealProtocolBlends = new ArrayList();
    public ArrayList otherPerfluorinatedGases = new ArrayList();
    public ArrayList fluorinatedEthers = new ArrayList();
    public ArrayList otherRefrigirants = new ArrayList();

    //Values
    public ArrayList kyotoProtocolStandardVals = new ArrayList();
    public ArrayList kyotoProtocolBlendsVals = new ArrayList();
    public ArrayList montrealProtocolStandardVals = new ArrayList();
    public ArrayList montrealProtocolBlendsVals = new ArrayList();
    public ArrayList otherPerfluorinatedGasesVals = new ArrayList();
    public ArrayList fluorinatedEthersVals = new ArrayList();
    public ArrayList otherRefrigirantsVals = new ArrayList();

    //Screens
    public TextMeshPro activityScreen;
    public TextMeshPro emissionScreen;

    void Start()
    {
        fillLists();
        activityScreen = GameObject.Find("TypeText").GetComponent<TextMeshPro>();
        emissionScreen = GameObject.Find("EmissionText").GetComponent<TextMeshPro>();
        InitialScreenTextSetup();

    }

    public void fillLists()
    {
        string startPath = Application.dataPath;
        string textsPath = startPath + "/TextFiles/Refrigerants/";

        string[] activitiesTextInfo = File.ReadAllLines(textsPath + "activities.txt");
        string[] kyotoProtocolStandardTextInfo = File.ReadAllLines(textsPath + "KyoProStd.txt");
        string[] kyotoProtocolBlendsTextInfo = File.ReadAllLines(textsPath + "KyoProBle.txt");
        string[] montrealProtocolStandardTextInfo = File.ReadAllLines(textsPath + "MontProStd.txt");
        string[] montrealProtocolBlendsTextInfo = File.ReadAllLines(textsPath + "MontProBle.txt");
        string[] otherPerfluorinatedGasesTextInfo = File.ReadAllLines(textsPath + "OtherPerfGas.txt");
        string[] fluorinatedEthersTextInfo = File.ReadAllLines(textsPath + "FluorinatedEthers.txt");
        string[] otherRefrigirantsTextInfo = File.ReadAllLines(textsPath + "OtherRef.txt");

        for (int i = 0; i < activitiesTextInfo.Length; i++)
        {
            activites.Add(activitiesTextInfo[i]);
        }

        AddToLists(kyotoProtocolStandard, kyotoProtocolStandardVals, kyotoProtocolStandardTextInfo);
        AddToLists(kyotoProtocolBlends, kyotoProtocolBlendsVals, kyotoProtocolBlendsTextInfo);
        AddToLists(montrealProtocolStandard, montrealProtocolStandardVals, montrealProtocolStandardTextInfo);
        AddToLists(montrealProtocolBlends, montrealProtocolBlendsVals, montrealProtocolBlendsTextInfo);
        AddToLists(otherPerfluorinatedGases, otherPerfluorinatedGasesVals, otherPerfluorinatedGasesTextInfo);
        AddToLists(fluorinatedEthers, fluorinatedEthersVals, fluorinatedEthersTextInfo);
        AddToLists(otherRefrigirants, otherRefrigirantsVals, otherRefrigirantsTextInfo);


    }

    public void AddToLists(ArrayList textList, ArrayList valuesList, string[] textInfo)
    {
        for (int i = 0; i < textInfo.Length; i++)
        {
            string[] split = textInfo[i].Split(' ');
            textList.Add(split[0]);
            valuesList.Add(split[1]);
        }
    }

    public void InitialScreenTextSetup()
    {
        activityScreen.text = activites[0].ToString();
        emissionScreen.text = kyotoProtocolStandard[0].ToString();

    }
}

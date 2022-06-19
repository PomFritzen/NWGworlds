using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class RefrigBtns : MonoBehaviour
{
    //Selectors
    //public int activitySelector = 0;
    //public int emissionSelector = 0;
    /*
    //Texts
    ArrayList activites = new ArrayList();
    ArrayList activeEmission = new ArrayList();
    ArrayList kyotoProtocolStandard = new ArrayList();
    ArrayList kyotoProtocolBlends = new ArrayList();
    ArrayList montrealProtocolStandard = new ArrayList();
    ArrayList montrealProtocolBlends = new ArrayList();
    ArrayList otherPerfluorinatedGases = new ArrayList();
    ArrayList fluorinatedEthers = new ArrayList();
    ArrayList otherRefrigirants = new ArrayList();

    //Values
    ArrayList kyotoProtocolStandardVals = new ArrayList();
    ArrayList kyotoProtocolBlendsVals = new ArrayList();
    ArrayList montrealProtocolStandardVals = new ArrayList();
    ArrayList montrealProtocolBlendsVals = new ArrayList();
    ArrayList otherPerfluorinatedGasesVals = new ArrayList();
    ArrayList fluorinatedEthersVals = new ArrayList();
    ArrayList otherRefrigirantsVals = new ArrayList();

    //Screens
    TextMeshPro activityScreen;
    TextMeshPro emissionScreen;

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

    } */

    RefrigLister lister;

    private void Start()
    {
        lister = GameObject.Find("Lister").GetComponent<RefrigLister>();
    }

    public void NextOnActivitiesList()
    {

        if ((lister.activitySelector+1) > (lister.activites.Count-1))
        {
            lister.activitySelector = 0;
            lister.activityScreen.text = lister.activites[lister.activitySelector].ToString();
            SetEmissionList(lister.activitySelector);
        } else
        {
            lister.activitySelector += 1;
            lister.activityScreen.text = lister.activites[lister.activitySelector].ToString();
            SetEmissionList(lister.activitySelector);
        }
    }

    public void PreviousOnActivitesList()
    {
        if ((lister.activitySelector -1) < 0)
        {
            lister.activitySelector = lister.activites.Count - 1;
            lister.activityScreen.text = lister.activites[lister.activitySelector].ToString();
            SetEmissionList(lister.activitySelector);
        } else
        {
            lister.activitySelector -= 1;
            lister.activityScreen.text = lister.activites[lister.activitySelector].ToString();
            SetEmissionList(lister.activitySelector);
        }
    }

    public void SetEmissionList(int activeActivity)
    {
        lister.emissionSelector = 0;

        if (activeActivity == 0)
        {
            lister.activeEmission.Clear();
            lister.activeEmission.AddRange(lister.kyotoProtocolStandard);
            lister.emissionScreen.text = lister.activeEmission[lister.emissionSelector].ToString();
        }

        if (activeActivity == 1)
        {
            lister.activeEmission.Clear();
            lister.activeEmission.AddRange(lister.kyotoProtocolBlends);
            lister.emissionScreen.text = lister.activeEmission[lister.emissionSelector].ToString();
        }

        if (activeActivity == 2)
        {
            lister.activeEmission.Clear();
            lister.activeEmission.AddRange(lister.montrealProtocolStandard);
            lister.emissionScreen.text = lister.activeEmission[lister.emissionSelector].ToString();
        }

        if (activeActivity == 3)
        {
            lister.activeEmission.Clear();
            lister.activeEmission.AddRange(lister.montrealProtocolBlends);
            lister.emissionScreen.text = lister.activeEmission[lister.emissionSelector].ToString();
        }

        if (activeActivity == 4)
        {
            lister.activeEmission.Clear();
            lister.activeEmission.AddRange(lister.otherPerfluorinatedGases);
            lister.emissionScreen.text = lister.activeEmission[lister.emissionSelector].ToString();
        }

        if (activeActivity == 5)
        {
            lister.activeEmission.Clear();
            lister.activeEmission.AddRange(lister.fluorinatedEthers);
            lister.emissionScreen.text = lister.activeEmission[lister.emissionSelector].ToString();
        }

        if (activeActivity == 6)
        {
            lister.activeEmission.Clear();
            lister.activeEmission.AddRange(lister.otherRefrigirants);
            lister.emissionScreen.text = lister.activeEmission[lister.emissionSelector].ToString();
        }

    }

    public void NextOnEmissionList()
    {
        if ((lister.emissionSelector +1) > (lister.activeEmission.Count-1))
        {
            lister.emissionSelector = 0;
            lister.emissionScreen.text = lister.activeEmission[lister.emissionSelector].ToString();
        } else
        {
            lister.emissionSelector += 1;
            lister.emissionScreen.text = lister.activeEmission[lister.emissionSelector].ToString();
        }
    }
    public void PreviousOnEmissionList()
    {
        if ((lister.emissionSelector -1) < 0)
        {
            lister.emissionSelector = lister.activeEmission.Count - 1;
            lister.emissionScreen.text = lister.activeEmission[lister.emissionSelector].ToString();
        } else
        {
            lister.emissionSelector -= 1;
            lister.emissionScreen.text = lister.activeEmission[lister.emissionSelector].ToString();
        }
    }
    
}

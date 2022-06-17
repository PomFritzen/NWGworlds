using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinentValueDisplays : MonoBehaviour
{
    public string activeCountry;
    public int currentField;

    public ArrayList europe;
    public ArrayList asia;
    public ArrayList africa;
    public ArrayList australiaOceana;
    public ArrayList northAmerica;
    public ArrayList southAmerica;

    // Start is called before the first frame update
    void Start()
    {
        africa = new ArrayList();
        asia = new ArrayList();
        australiaOceana = new ArrayList();
        europe = new ArrayList();
        northAmerica = new ArrayList();
        southAmerica = new ArrayList();

        FillLists();
    }

    public void FillLists()
    {
        //No values
        africa.Add(0.0f);

        for (int i = 0; i < 8; i++)
        {
            asia.Add(0.0f);
        }

        for (int i = 0; i < 11; i++)
        {
            australiaOceana.Add(0.0f);
        }

        for (int i = 0; i < 31; i++)
        {
            europe.Add(0.0f);
        }

        for (int i = 0; i < 40; i++)
        {
            northAmerica.Add(0.0f);
        }

        //No values
        southAmerica.Add(0.0f);
    }

}

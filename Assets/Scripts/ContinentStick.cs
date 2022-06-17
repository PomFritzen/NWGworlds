using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinentStick : MonoBehaviour
{

    Rigidbody rbody;
    float startMass;

    [SerializeField] GameObject inputFieldObj; 

    // Start is called before the first frame update
    void Start()
    {
        rbody = gameObject.GetComponent<Rigidbody>();
        startMass = rbody.mass;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*
        if (collision.gameObject.transform.parent.gameObject.name == "Europe" || collision.gameObject.transform.parent.gameObject.name == "Asia" || collision.gameObject.transform.parent.gameObject.name == "AustraliaOceana" || collision.gameObject.transform.parent.gameObject.name == "Africa" || collision.gameObject.transform.parent.gameObject.name == "SouthAmerica" || collision.gameObject.transform.parent.gameObject.name == "NorthAmerica")
        {
            
            //rbody.velocity = Vector3.zero;
            //rbody.angularVelocity = Vector3.zero;
            //rbody.useGravity = false;
            //rbody.mass = 0.0f;
            
            
            rbody.constraints = RigidbodyConstraints.FreezeAll;          
            
        }
        */

        if (collision.gameObject.transform.parent.gameObject.name == "Africa")
        {
            rbody.constraints = RigidbodyConstraints.FreezeAll;
            ContinentCountries continentCountries = new ContinentCountries();
            continentCountries.GetContinentCountries("AfricaList.txt");
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().activeCountry = collision.gameObject.transform.parent.gameObject.name;
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField = 0;
        }

        if (collision.gameObject.transform.parent.gameObject.name == "AustraliaOceana")
        {
            rbody.constraints = RigidbodyConstraints.FreezeAll;
            ContinentCountries continentCountries = new ContinentCountries();
            continentCountries.GetContinentCountries("AusOceList.txt");
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().activeCountry = collision.gameObject.transform.parent.gameObject.name;
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField = 0;
        }

        if (collision.gameObject.transform.parent.gameObject.name == "Europe")
        {
            rbody.constraints = RigidbodyConstraints.FreezeAll;
            ContinentCountries continentCountries = new ContinentCountries();
            continentCountries.GetContinentCountries("EuropeList.txt");
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().activeCountry = collision.gameObject.transform.parent.gameObject.name;
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField = 0;
        }

        if (collision.gameObject.transform.parent.gameObject.name == "NorthAmerica")
        {
            rbody.constraints = RigidbodyConstraints.FreezeAll;
            ContinentCountries continentCountries = new ContinentCountries();
            continentCountries.GetContinentCountries("NAmericaList.txt");
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().activeCountry = collision.gameObject.transform.parent.gameObject.name;
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField = 0;
        }

        if (collision.gameObject.transform.parent.gameObject.name == "SouthAmerica")
        {
            rbody.constraints = RigidbodyConstraints.FreezeAll;
            ContinentCountries continentCountries = new ContinentCountries();
            continentCountries.GetContinentCountries("SAmericaList.txt");
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().activeCountry = collision.gameObject.transform.parent.gameObject.name;
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField = 0;
        }

        if (collision.gameObject.transform.parent.gameObject.name == "Asia")
        {
            rbody.constraints = RigidbodyConstraints.FreezeAll;
            ContinentCountries continentCountries = new ContinentCountries();
            continentCountries.GetContinentCountries("AsiaList.txt");
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().activeCountry = collision.gameObject.transform.parent.gameObject.name;
            GameObject.Find("ListValueContainer").GetComponent<ContinentValueDisplays>().currentField = 0;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        
        //rbody.useGravity = true;
        //rbody.mass = startMass;
        
        
        rbody.constraints = RigidbodyConstraints.None;
       
       
    }

}

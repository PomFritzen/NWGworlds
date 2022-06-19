using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowManyCars : MonoBehaviour
{
    public ArrayList listOfCars = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public ArrayList GetCarList()
    {
        return listOfCars;
    }

    public void AddCarToList(CurrentCarInformation car)
    {
        listOfCars.Add(car);
    }
}

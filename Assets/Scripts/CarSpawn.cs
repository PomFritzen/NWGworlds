using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    GameObject smallCar;
    GameObject mediumCar;
    GameObject largeCar;
    GameObject averageCar;


    // Start is called before the first frame update
    void Start()
    {
        smallCar = GameObject.Find("SmallCar");
        mediumCar = GameObject.Find("MediumCar");
        largeCar = GameObject.Find("LargeCar");
        averageCar = GameObject.Find("AverageCar");

    }

    // Update is called once per frame
    void Update()
    {
        GameObject clone;
        int rndSpawnPoint = Random.Range(1, 11);
        int rndCar = Random.Range(1, 5);
        GameObject spawnPoint = GameObject.Find("Spawnpoint" + rndSpawnPoint);

        if (rndCar == 1)
        {
            clone = Instantiate(smallCar, spawnPoint.transform.position, Quaternion.identity);

            if (rndSpawnPoint < 6)
            {
                clone.transform.Rotate(180, 0, 180);
            }

        }

        if (rndCar == 2)
        {
            clone = Instantiate(mediumCar, spawnPoint.transform.position, Quaternion.identity);

            if (rndSpawnPoint < 6)
            {
                clone.transform.Rotate(180, 0, 180);
            }
        }

        if (rndCar == 3)
        {
            clone = Instantiate(largeCar, spawnPoint.transform.position, Quaternion.identity);

            if (rndSpawnPoint < 6)
            {
                clone.transform.Rotate(180, 0, 180);
            }
        }

        if (rndCar == 4)
        {
            clone = Instantiate(averageCar, spawnPoint.transform.position, Quaternion.identity);

            if (rndSpawnPoint < 6)
            {
                clone.transform.Rotate(180, 0, 180);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SnowmanSpawner : MonoBehaviour
{

    public int snowmen = 0;
    public GameObject snowman;
    
    public void SpawnSnowmen(int amountValue)
    {
        
        int counter = snowmen/100;
        int snowmenToSpawn = (amountValue - snowmen)/100;

        while (counter < snowmenToSpawn)
        {
            //Spawnarea --> X(-15, 15), Y(), Z(6, -23)

            Instantiate(snowman, new Vector3(Random.Range(-15.0f, 15.0f), -0.2f, Random.Range(-23.0f, 6.0f)), Quaternion.identity);
            counter++;
        }
    }

}

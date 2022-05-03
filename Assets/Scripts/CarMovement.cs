using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * 3));
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("WALL WAS HIT");
        int rndSpawnPoint = Random.Range(1, 11);
        GameObject spawnPoint = GameObject.Find("Spawnpoint" + rndSpawnPoint);

        if (other.gameObject.name == "RespawnWallR" || other.gameObject.name == "RespawnWallL")
        {
            transform.position = spawnPoint.transform.position;

            if (rndSpawnPoint < 6)
            {
                transform.Rotate(180, 0, 180);
            }

        }
    }
}

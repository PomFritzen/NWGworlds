using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RespawnBalls : MonoBehaviour
{

    GameObject spawnpoint;
    Rigidbody rbody;

    // Start is called before the first frame update
    void Start()
    {
        string nameOfBall = name;
        spawnpoint = GameObject.Find(nameOfBall+"Spawn");
        rbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "HoopHit")
        {
            rbody.velocity = Vector3.zero;
            rbody.angularVelocity = Vector3.zero;
            transform.position = spawnpoint.transform.position;
        }
    }

    

}

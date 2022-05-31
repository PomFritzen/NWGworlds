using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class RespawnBalls : MonoBehaviour
{

    GameObject spawnpoint;
    Rigidbody rbody;
    Transform originalRotation;

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
        /*
        if (other.gameObject.name == "HoopHit" || other.gameObject.transform.parent.gameObject.name == "TriggerZone")
        {
            rbody.velocity = Vector3.zero;
            rbody.angularVelocity = Vector3.zero;
            transform.position = spawnpoint.transform.position;
        }
        */

        if (other.gameObject.name == "HoopHit" && name == "Scope1Ball")
        {
            SceneManager.LoadScene(8);
        }

        if (other.gameObject.transform.parent.gameObject.name == "TriggerZone")
        {
            rbody.velocity = Vector3.zero;
            rbody.angularVelocity = Vector3.zero;
            transform.position = spawnpoint.transform.position;
        }
    }

    

}

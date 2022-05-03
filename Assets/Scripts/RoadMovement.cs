using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    public int speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CollisionWall")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-40);
        }
    }
}

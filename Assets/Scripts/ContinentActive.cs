using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinentActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        var children = gameObject.transform.parent.GetComponentsInChildren<Renderer>();
        foreach (Renderer childRend in children)
        {
            childRend.enabled = true;
        }

        /*
        if (collision.gameObject.name == "ContStick")
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        */
    }

    private void OnCollisionExit(Collision collision)
    {

        var children = gameObject.transform.parent.GetComponentsInChildren<Renderer>();
        foreach (Renderer childRend in children)
        {
            childRend.enabled = false;
        }

        /*
        if (collision.gameObject.name == "ContStick")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        */
    }
}

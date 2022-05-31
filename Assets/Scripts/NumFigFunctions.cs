using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NumFigFunctions : MonoBehaviour
{

    Vector3 originalPosition;
    Quaternion originalRotation;
    bool destroyInstance;

    private void Start()
    {
        destroyInstance = true;
        originalPosition = this.gameObject.transform.position;
        originalRotation = this.gameObject.transform.rotation;
    }

    public void OnRelease()
    {
        
        GameObject gameObjectClone = Instantiate(this.gameObject, originalPosition, originalRotation);
        if (destroyInstance == true)
        {
            Destroy(this.gameObject);
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "InputZoneCol")
        {
            destroyInstance = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "InputZoneCol")
        {
            destroyInstance = true;
        }
    }

}

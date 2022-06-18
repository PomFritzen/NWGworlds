using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckForDestruction : MonoBehaviour
{

    public bool shouldDestroy;

    private void Start()
    {
        shouldDestroy = false;
    }

    private void Update()
    {
        if (shouldDestroy == true)
        {
            Destroy(this.gameObject);
        } 
    }

}


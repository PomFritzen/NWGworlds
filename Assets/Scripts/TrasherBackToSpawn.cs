using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrasherBackToSpawn : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GameObject table = GameObject.Find("PCR_Table").GetComponent<GameObject>();
        if (other.gameObject.Equals("Trasher"))
        {
            this.transform.position = table.transform.position;
        }
    }
}

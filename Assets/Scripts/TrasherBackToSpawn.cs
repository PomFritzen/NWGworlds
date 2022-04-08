using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrasherBackToSpawn : MonoBehaviour
{
    GameObject table;

    void Awake()
    {
        table = GameObject.Find("PBR_Table");
    }


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "Trasher")
        {
            var pos = table.transform.position;
            pos.y = pos.y + 1;
            this.transform.position = pos;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinentDestroyFields : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "DestroyFieldsArea" && GameObject.Find("FieldDestroyer").GetComponent<ContinentFieldDestroyer>().shouldDestroy == true)
        {
            Destroy(gameObject);
        }
    }
}

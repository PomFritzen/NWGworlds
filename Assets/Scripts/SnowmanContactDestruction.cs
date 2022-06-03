using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanContactDestruction : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Floor")
        {
            Destroy(this.gameObject);
        }

    }
}

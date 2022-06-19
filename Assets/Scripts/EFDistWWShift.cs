using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EFDistWWShift : MonoBehaviour
{
    TextMeshPro efdistText;


    // Start is called before the first frame update
    void Start()
    {
        efdistText = GameObject.Find("EFOrDistText").GetComponent<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "EFOrDistColEF")
        {
            efdistText.text = "Efficiency";
        }

        if (other.gameObject.name == "EFOrDistColDist")
        {
            efdistText.text = "Distance";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "EFOrDistColEF" || other.gameObject.name == "EFOrDistColDist")
        {
            efdistText.text = "EF or Dist";
        }
    }
}

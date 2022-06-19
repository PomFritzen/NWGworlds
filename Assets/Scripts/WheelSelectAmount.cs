using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WheelSelectAmount : MonoBehaviour
{

    TextMeshPro amountText;

    // Start is called before the first frame update
    void Start()
    {
        amountText = GameObject.Find("CarAmountValue").GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        int currValue = Int32.Parse(amountText.text);


        if (other.gameObject.name == "WheelColL" && Time.frameCount % 2 == 0)
        {
            if (currValue > 0)
            {
                currValue -= 1;
                amountText.text = "" + currValue;
            }
            
        }

        if (other.gameObject.name == "WheelColR" && Time.frameCount % 2 == 0)
        {
            currValue += 1;
            amountText.text = "" + currValue;
        }
    }
}

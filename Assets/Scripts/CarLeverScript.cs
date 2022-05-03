using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarLeverScript : MonoBehaviour
{
    TextMeshPro morkm;

    // Start is called before the first frame update
    void Start()
    {
        morkm = GameObject.Find("morkmNums").GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "morkmColliderK")
        {
            //Debug.Log("K was hit");
            morkm.text = "Kilometers";
        }

        if (other.gameObject.name == "morkmColliderM")
        {
            //Debug.Log("M was hit");
            morkm.text = "Miles";
        }
    }
}

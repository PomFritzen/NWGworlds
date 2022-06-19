using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KnobMultiplier : MonoBehaviour
{
    TextMeshPro multiText;

    // Start is called before the first frame update
    void Start()
    {
        multiText = GameObject.Find("multiValue").GetComponent<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other)
    {
        string col = "KnobAmtCol";

        if (other.gameObject.name == col + "1")
        {
            multiText.text = "1";
        }

        if (other.gameObject.name == col + "2")
        {
            multiText.text = "10";
        }

        if (other.gameObject.name == col + "3")
        {
            multiText.text = "100";
        }

        if (other.gameObject.name == col + "4")
        {
            multiText.text = "1000";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        string col = "KnobAmtCol";

        if (collision.gameObject.name == col + "1")
        {
            multiText.text = "1";
        }

        if (collision.gameObject.name == col + "2")
        {
            multiText.text = "10";
        }

        if (collision.gameObject.name == col + "3")
        {
            multiText.text = "100";
        }

        if (collision.gameObject.name == col + "4")
        {
            multiText.text = "1000";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumFigReturnVal : MonoBehaviour
{
    int value = 0;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "NumFig0")
        {
            value = 0;
        }

        if (other.gameObject.name == "NumFig1")
        {
            value = 1;
        }

        if (other.gameObject.name == "NumFig2")
        {
            value = 2;
        }

        if (other.gameObject.name == "NumFig3")
        {
            value = 3;
        }
        if (other.gameObject.name == "NumFig4")
        {
            value = 4;
        }

        if (other.gameObject.name == "NumFig5")
        {
            value = 5;
        }

        if (other.gameObject.name == "NumFig6")
        {
            value = 6;
        }

        if (other.gameObject.name == "NumFig7")
        {
            value = 7;
        }

        if (other.gameObject.name == "NumFig8")
        {
            value = 8;
        }

        if (other.gameObject.name == "NumFig9")
        {
            value = 9;
        }
    }

    public int GetValue()
    {
        return value;
    }
}

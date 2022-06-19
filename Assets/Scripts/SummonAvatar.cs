using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonAvatar : MonoBehaviour
{
    public GameObject avatarRed;
    public GameObject avatarBlue;
    public GameObject avatarGreen;
    public void Summon()
    {
        string avatar = CalculationFunctions.GetAvatar();
        Vector3 pos = transform.position;
        pos.y = pos.y - 1;
        pos.x = pos.x + 3;
        pos.z = pos.z - 7;

        if (avatar == "Red")
        {
            Instantiate(avatarRed, pos, Quaternion.identity);
        }

        if (avatar == "Blue")
        {
            Instantiate(avatarBlue, pos, Quaternion.identity);
        }

        if (avatar == "Green")
        {
            Instantiate(avatarGreen, pos, Quaternion.identity);
        }


    }
}

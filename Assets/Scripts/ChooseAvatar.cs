using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseAvatar : MonoBehaviour
{
    public void ChooseAvatarAndProgress()
    {
        string[] split = transform.parent.parent.name.Split('_');
        Debug.Log(split[0]);
        Debug.Log(split[1]);
        string avatar = split[1];
        CalculationFunctions.SetAvatar(avatar);
        SceneManager.LoadScene(1);
    }

}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDMenu : MonoBehaviour
{
    public TextMeshProUGUI simpleUIText;

    public void KWBtn1Clicked()
    {
        Debug.Log("ButtonWasClicked");
        SceneManager.LoadScene(3);
    }

    public void KWBtn2Clicked()
    {
        Debug.Log("ButtonWasClicked");
    }

    public void KWBtn3Clicked()
    {
        Debug.Log("ButtonWasClicked");
    }

    public void BWBtn1Clicked()
    {
        SceneManager.LoadScene(2);
    }

    public void BWBtn2Clicked()
    {
        Debug.Log("ButtonWasClicked");
    }

    public void BWBtn3Clicked()
    {
        Debug.Log("ButtonWasClicked");
    }

    public void HomeBtnClicked()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayControllerButtons : MonoBehaviour
{
    public GameObject uIButtonDisplay;
    public GameObject missionGuides;

    public void EnableControllerButtonDisplay()
    {
        uIButtonDisplay.SetActive(true);
        missionGuides.SetActive(false);
    }

    public void DisableControllerButtonDisplay()
    {
        uIButtonDisplay.SetActive(false);
    }
}

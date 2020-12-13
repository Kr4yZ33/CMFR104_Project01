using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayControllerButtons : MonoBehaviour
{
    public GameObject uIButtonDisplay; // reference to the diagram for our UI button display
    public GameObject missionGuides; // refernce to the parent for all of the mission cards that display on the tablet

    /// <summary>
    /// public function used by buttons to enable the controller button diagram
    /// </summary>
    public void EnableControllerButtonDisplay()
    {
        uIButtonDisplay.SetActive(true); // enable the button display diagram
        missionGuides.SetActive(false); // disable the parent for the mission guide cards
    }

    /// <summary>
    /// public function used by UI buttons to disable the button
    /// control diagram
    /// </summary>
    public void DisableControllerButtonDisplay()
    {
        uIButtonDisplay.SetActive(false); // disable the button display diagram
    }
}

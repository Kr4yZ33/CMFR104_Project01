using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuController : MonoBehaviour
{
    public GameObject startMenu; // reference to the start menu UI parent
    
    /// <summary>
    /// function that disabled the start menu UI when the 
    /// start button is pressed
    /// </summary>
    public void StartButtonPressed()
    {
        startMenu.SetActive(false); // disable the start menu UI parent
    }
}

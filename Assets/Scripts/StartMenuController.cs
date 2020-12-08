using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuController : MonoBehaviour
{
    public GameObject startMenu;
    
    public void StartButtonPressed()
    {
        startMenu.SetActive(false);
    }
}

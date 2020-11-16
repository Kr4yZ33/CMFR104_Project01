using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalExit : MonoBehaviour
{
    public HammerController hammerController;
    
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            hammerController.portalReady = false;
            hammerController.portalOpen = false;
        }
    }
}

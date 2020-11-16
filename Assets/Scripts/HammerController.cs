using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerController : MonoBehaviour
{
    public PortalController portalController;
    
    public Vector3 target;

    public bool canThrow;
    public bool portalOpen;

    //portal
    public bool portalReady = true;

    private void Update()
    {
        if (portalReady == false)
        {
            portalController.DestoryPortal();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canThrow = true;

        if (other.gameObject.CompareTag("Player"))
        {
            canThrow = true;
            portalReady = true;
        }

        if (other.gameObject.CompareTag("TilePlatform"))
        {
            canThrow = false;

            if (portalOpen == true)
            {
                return;
            }
            if (canThrow == false && portalReady == true)
            {
                portalController.CreatePortal();
                portalOpen = true;
            }
        }

        if (other.gameObject.CompareTag("Ground"))
        {
            canThrow = false;

            if (portalOpen == true)
            {
                return;
            }
            if (canThrow == false && portalReady == true)
            {
                portalController.CreatePortal();
                portalOpen = true;
            }
        }
    }
}

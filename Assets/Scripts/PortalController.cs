using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public PortalEntryPrefab portalEntryPrefabScript;
    
    public GameObject portalEntry;
    public Vector3 portalEntryTransform;
    public GameObject portalExit;

    
    public void CreatePortal()
    {
        portalEntry.SetActive(true);
        portalEntry.transform.position = portalEntryTransform;
        portalExit.SetActive(true);
        portalEntryPrefabScript.SpawnPortalEntry();
    }

    public void DestoryPortal()
    {
        portalEntry.SetActive(false);
        portalExit.SetActive(false);
    }
}

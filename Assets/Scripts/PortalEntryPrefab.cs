using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalEntryPrefab : MonoBehaviour
{
    public PortalController portalController;
    
    public GameObject portalPrefab;
    public Transform portalEntryTransform;
    GameObject clone;

    private void Start()
    {
        portalEntryTransform.position = portalController.portalEntry.transform.position;
    }

    public void SpawnPortalEntry()
    {
        clone = Instantiate(portalPrefab, portalEntryTransform.position, portalEntryTransform.rotation);
    }

    public void DestroyPortalEntry()
    {
        Destroy(clone);
    }
}

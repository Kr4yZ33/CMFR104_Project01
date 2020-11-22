using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPlatformGridSnap : MonoBehaviour
{
    //public BuildPlatformGridSnapController buildPlatformGridSnapController;
    
    public GameObject targetTile;
    public bool tileSnappedInPlace;

    // use button to rotate snapped tile

    private void FixedUpdate()
    {
        //buildPlatformGridSnapController.targetTile = targetTile;
        
        //if(buildPlatformGridSnapController.snapTile == true)
        //{
            //SnapTileInPlace();
        //}
    }

    public void SnapTileInPlace()
    {
        targetTile.transform.position = gameObject.transform.position;
        targetTile.transform.rotation = gameObject.transform.rotation;
        tileSnappedInPlace = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 18)
        {
            targetTile = other.gameObject;
        }
    }
}

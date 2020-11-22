using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHeld : MonoBehaviour
{
    public HapticsController hapticsController;
    //public BuildPlatformGridSnapController buildPlatformGridSnapController;

    public bool isHeld = false;

    public bool onBuildPlatform;

    public GameObject buildPlatform; // platform

    public Transform targetTransform;

    //private void FixedUpdate()
    //{
        //if (isHeld == false)
        //{
            //buildPlatformGridSnapController.tileSnappedInPlace = false;
        //}

        //if(buildPlatformGridSnapController.lockTileInPlace == true)
        //{
            //gameObject.transform.position = buildPlatformGridSnapController.targetTile.transform.position;
            //gameObject.transform.rotation = buildPlatformGridSnapController.targetTile.transform.rotation;
        //}
    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TilePlatform"))
        {
            onBuildPlatform = true;
        }

        if(other.gameObject.CompareTag("Player"))
        {
            hapticsController.HoverEntryHaptic();
            isHeld = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hapticsController.HoverEntryHaptic();
            isHeld = false;
            //buildPlatformGridSnapController.tileSnappedInPlace = false;
        }

        if (other.gameObject.CompareTag("TilePlatform"))
        {
            onBuildPlatform = false;
        }

        if (isHeld == false && onBuildPlatform == true)
        {
           //buildPlatformGridSnapController.lockTileInPlace = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHeld : MonoBehaviour
{
    public HapticsController hapticsController;
    public BuildPlatformGridSnap buildPlatformGridSnap;

    public bool isHeld = false;

    public bool onBuildPlatform;

    public GameObject buildPlatform; // platform

    public Transform targetTransform;

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
            buildPlatformGridSnap.tileSnappedInPlace = false;
        }

        if (other.gameObject.CompareTag("TilePlatform"))
        {
            onBuildPlatform = false;
        }

        if (isHeld == false && onBuildPlatform == true)
        {
            buildPlatformGridSnap.targetTile = gameObject;
            buildPlatformGridSnap.SnapTileInPlace();
        }
    }
}

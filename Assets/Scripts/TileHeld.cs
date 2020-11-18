using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHeld : MonoBehaviour
{
    public bool isHeld = false;

    public bool onBuildPlatform;

    public GameObject buildPlatform; // platform

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TilePlatform"))
        {
            onBuildPlatform = true;
        }

        if(other.gameObject.CompareTag("Player"))
        {
            isHeld = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isHeld = false;
        }

        if (other.gameObject.CompareTag("TilePlatform"))
        {
            onBuildPlatform = false;
        }
    }
}

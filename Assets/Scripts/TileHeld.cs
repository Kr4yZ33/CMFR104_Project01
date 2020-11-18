using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHeld : MonoBehaviour
{
    public bool isHeld = false;

    public bool onBuildPlatform;

    public GameObject buildPlatform; // platform

    private void Update()
    {
        if (onBuildPlatform == true && isHeld != true)
        {
            ParentTileToPlatform();
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TilePlatform"))
        {
            onBuildPlatform = true;
        }

        if (isHeld == true)
        {
            return;
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
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    void ParentTileToPlatform()
    {
        gameObject.transform.parent = buildPlatform.transform; //tile is now the child of build platform
    }
}

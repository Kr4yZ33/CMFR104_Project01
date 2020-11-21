using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPlatformGridSnapController : MonoBehaviour
{
    public bool snapTile;
    public bool tileSnappedInPlace;
    public bool lockTileInPlace;
    public GameObject targetTile;

    private void FixedUpdate()
    {
        if(tileSnappedInPlace == false)
        {
            lockTileInPlace = false;
        }
    }

}

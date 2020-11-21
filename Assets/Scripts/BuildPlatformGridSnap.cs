using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPlatformGridSnap : MonoBehaviour
{
    public GameObject targetTile;
    public bool tileSnappedInPlace;

    // use button to rotate snapped tile

    public void SnapTileInPlace()
    {
        targetTile.transform.position = gameObject.transform.position;
        targetTile.transform.rotation = gameObject.transform.rotation;
        tileSnappedInPlace = true;
    }
}

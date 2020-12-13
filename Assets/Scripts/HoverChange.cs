using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverChange : MonoBehaviour
{
    
    public GameObject trackMesh; // reference to the track mesh on the tile

    /// <summary>
    /// This disables the track mesh, under it there is a yellow mesh that actc as the hover colour
    /// this allows indivual changing of the colour if needed
    /// </summary>
    public void HoverColour()
    {
        trackMesh.SetActive(false); // set the tile mesh to disabled (usually grass or rock around the endges and not the centre mesh)
    }

    /// <summary>
    /// enables the track mesh
    /// </summary>
    public void MakeOriginalColour()
    {
        trackMesh.SetActive(true); // enable the tile mesh again
    }
}

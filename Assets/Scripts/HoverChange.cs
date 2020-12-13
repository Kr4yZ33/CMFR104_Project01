using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverChange : MonoBehaviour
{
    
    public GameObject trackMesh;

    public void HoverColour()
    {
        trackMesh.SetActive(false);
    }

    public void MakeOriginalColour()
    {
        trackMesh.SetActive(true);
    }
}

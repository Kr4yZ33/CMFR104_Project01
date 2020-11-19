using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTrainHorn : MonoBehaviour
{
    
    public bool playedHornClip;
    
    private void OnTriggerEnter(Collider other)
    {
        
        playedHornClip = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playedHornClip = false;
    }
}

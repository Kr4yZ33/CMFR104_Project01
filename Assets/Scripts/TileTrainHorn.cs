using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTrainHorn : MonoBehaviour
{
    public AudioManager audioManager; // reference to the Audio Manager script
    
    private void OnTriggerEnter(Collider other) // On trigger enter
    {
        audioManager.PlayHornClip(); // call the Play Horn Clip function from the audio manager script
    }
}

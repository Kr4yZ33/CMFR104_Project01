using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSnapConnection : MonoBehaviour
{
    public HapticsController hapticsController;
    
    public AudioSource audioSource;
    public AudioClip trackConnectedClip;
    
    public Transform closestEdge;
    public float volume = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("TrackEdge"))
        {
            closestEdge = other.gameObject.transform;
            audioSource.PlayOneShot(trackConnectedClip, volume);
            hapticsController.trackConnected = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        hapticsController.trackConnected = false;
    }
}

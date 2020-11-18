using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSnapConnection : MonoBehaviour
{
    public AudioManager audioManager;
    
    public Transform closestEdge;
    public bool connectionClipPlayed = false;
    public AudioClip trackConnectClip;
    
    private void Start()
    {
        //ovrGrabbable = GetComponent<OVRGrabbable>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TrackEdge"))
        {
            closestEdge = other.gameObject.transform;
            
            if(connectionClipPlayed == true)
            {
                return;
            }

            audioManager.PlayTrackConnectionClip();

            //VibrationManager.singleton.TriggerVibration(trackConnectClip, ovrGrabbable.grabbedBy.GetController());
            
            connectionClipPlayed = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TrackEdge"))
        {
            connectionClipPlayed = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSnapConnection : MonoBehaviour
{
    public Transform closestEdge;
    public bool connectionClipPlayed;
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

            //if()

            //VibrationManager.singleton.TriggerVibration(trackConnectClip, ovrGrabbable.grabbedBy.GetController());
            GetComponent<AudioSource>().PlayOneShot(trackConnectClip);
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

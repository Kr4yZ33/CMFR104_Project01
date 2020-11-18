using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSnapConnection : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip trackConnectedClip;
    
    public Transform closestEdge;
    public bool connectionClipPlayed;
    public float volume = 0.5f;

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
            else
            {
                
                //VibrationManager.singleton.TriggerVibration(40, 2, 255 , ovrGrabbable.grabbedBy.GetController());

                audioSource.PlayOneShot(trackConnectedClip, volume);
                connectionClipPlayed = true;
            }
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

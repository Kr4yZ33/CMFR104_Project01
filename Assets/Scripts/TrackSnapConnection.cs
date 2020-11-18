using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSnapConnection : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip trackConnectedClip;
    
    public Transform closestEdge;
    //public bool connectionClipPlayed;
    public float volume = 0.5f;

    private OVRGrabbable ovrGrabbable;

    private void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //if(connectionClipPlayed == true)
        //{
            //return;
        //}
        
        if(other.gameObject.CompareTag("TrackEdge"))
        {
            closestEdge = other.gameObject.transform;
            audioSource.PlayOneShot(trackConnectedClip, volume);
            PlayVibrationHaptics();
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
        //if (other.gameObject.CompareTag("TrackEdge"))
        //{
            //connectionClipPlayed = false;
        //}
    //}

    void PlayVibrationHaptics()
    {
        VibrationManager.singleton.TriggerVibration(trackConnectedClip, ovrGrabbable.grabbedBy.GetController());
        
        //connectionClipPlayed = true;
    }
}

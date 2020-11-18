using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticsController : MonoBehaviour
{
    public TrackSnapConnection trackSnapConnection;

    OVRHapticsClip buzz;
    public AudioClip trackConnect;
    public bool trackConnected;

    // Start is called before the first frame update
    void Start()
    {
        buzz = new OVRHapticsClip(trackConnect);
    }

    private void Update()
    {
        if(trackConnected == true)
        {
            OVRHaptics.LeftChannel.Mix(buzz);
            OVRHaptics.RightChannel.Mix(buzz);
        }
    }

    private void OnTriggerEnter(Collider hand)
    {
        if(hand.gameObject.CompareTag("LeftHand"))
        {
            if(OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
            {
                OVRHaptics.LeftChannel.Mix(buzz);
            }
        }
        if (hand.gameObject.CompareTag("RightHand"))
        {
            if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
            {
                OVRHaptics.RightChannel.Mix(buzz);
            }
        }
    }
    private void OnTriggerExit(Collider hand)
    {
        if (hand.gameObject.CompareTag("LeftHand"))
        {
            OVRHaptics.LeftChannel.Mix(buzz);
        }
        if (hand.gameObject.CompareTag("RightHand"))
        {
            OVRHaptics.RightChannel.Mix(buzz);
        }
    }
}

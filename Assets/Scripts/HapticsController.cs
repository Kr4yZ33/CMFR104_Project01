using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticsController : MonoBehaviour
{
    OVRHapticsClip buzz;
    public AudioClip trackConnect;
    public bool trackConnected;
    public bool trackConnectedRhand;
    public bool trackConnectedLhand;

    // Start is called before the first frame update
    void Start()
    {
        buzz = new OVRHapticsClip(trackConnect);
    }

    private void Update()
    {
        if(trackConnectedRhand == true)
        {
            OVRHaptics.RightChannel.Mix(buzz);
        }

        if (trackConnectedRhand == true)
        {
            OVRHaptics.LeftChannel.Mix(buzz);
        } 
    }

    private void OnTriggerEnter(Collider hand)
    {
        if(hand.gameObject.CompareTag("LeftHand"))
        {
            if(OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
            {
                OVRHaptics.LeftChannel.Mix(buzz);
                trackConnectedLhand = true;
            }
        }
        if (hand.gameObject.CompareTag("RightHand"))
        {
            if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
            {
                OVRHaptics.RightChannel.Mix(buzz);
                trackConnectedRhand = true;
            }
        }
    }
    private void OnTriggerExit(Collider hand)
    {
        if (hand.gameObject.CompareTag("LeftHand"))
        {
            OVRHaptics.LeftChannel.Mix(buzz);
            trackConnectedLhand = false;
        }
        if (hand.gameObject.CompareTag("RightHand"))
        {
            OVRHaptics.RightChannel.Mix(buzz);
            trackConnectedRhand = false;
        }
    }
}

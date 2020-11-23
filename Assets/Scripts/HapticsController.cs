using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticsController : MonoBehaviour
{
    OVRHapticsClip buzz; // reference to the OVR Haptic clip
    public AudioClip trackConnect; // reference to the track connected audio clip
    public bool trackConnected; // bool for if the track is connected or not
    public bool trackConnectedRhand; // bool showing if the right hand is the one holding the object
    public bool trackConnectedLhand; // bool showing if the left hand is the one holding the object
    public bool isHeld;

    // Start is called before the first frame update
    void Start()
    {
        buzz = new OVRHapticsClip(trackConnect); // set the ovr haptic clip to the track connect audio clip
    }

    private void Update()
    {
        if(trackConnectedRhand == true && trackConnected == true) // if the bool for right hand used is true
        {
            OVRHaptics.RightChannel.Mix(buzz); // use the buzz ovr haptic clip on the right controller.
        }

        if (trackConnectedLhand == true && trackConnected == true) // if the bool for left hand used is true
        {
            OVRHaptics.LeftChannel.Mix(buzz); // use the buzz ovr haptic clip on the left controller.
        } 
    }

    private void OnTriggerEnter(Collider hand) // on trigger enter
    {
        if (hand.gameObject.CompareTag("Player")) // if the object colliding with us is tagged player
        {
            isHeld = true; // set the bool for isHeld to true
        }

        if (hand.gameObject.CompareTag("LeftHand")) // if the object colliding with us is tagged LeftHand
        {
            if(OVRInput.Get(OVRInput.Button.SecondaryHandTrigger)) // if the trigger button is pressed
            {
                OVRHaptics.LeftChannel.Mix(buzz); // use the buzz ovr haptic clip on the left controller
                trackConnectedLhand = true; // set the bool for left hand in use to true
            }
        }
        if (hand.gameObject.CompareTag("RightHand")) // if the object colliding with us is tagged RightHand
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger)) // if the trigger button is pressed
            {
                OVRHaptics.RightChannel.Mix(buzz); // use the buzz ovr haptic clip on the right controller
                trackConnectedRhand = true; // set the bool for right hand in use to true
            }
        }
    }
    private void OnTriggerExit(Collider hand) // on trigger exit
    {
        if (hand.gameObject.CompareTag("Player")) // if the object colliding with us is tagged player
        {
            isHeld = false; // set the bool for isHeld to false
        }

        if (hand.gameObject.CompareTag("LeftHand")) // if the object colliding with us is tagged LeftHand
        {
            OVRHaptics.LeftChannel.Mix(buzz); // use the buzz ovr haptic clip on the left controller
            trackConnectedLhand = false; // set the bool for left hand in use to false
        }
        if (hand.gameObject.CompareTag("RightHand")) // if the object colliding with us is tagged RightHand
        {
            OVRHaptics.RightChannel.Mix(buzz); // use the buzz ovr haptic clip on the right controller
            trackConnectedRhand = false; // set the bool for right hand in use to false
        }
    }
}

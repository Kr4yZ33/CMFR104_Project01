using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JPHandScript : MonoBehaviour
{
    public JPColourChange theCube; // reference to the JP Colour Change script
    public TrackController trackController; // reference to the Track Controller script

    // Update is called once per frame
    void Update()
    {
        var hand = GetComponent<OVRHand>(); // Get the OVR hand component
        bool isIndexFingerPinching = hand.GetFingerIsPinching(OVRHand.HandFinger.Index); // bool for is the hand index finger is pinching or not

        if (isIndexFingerPinching) // if index finger is pinching
        {
            //is pinching., do something
            theCube.SetGreen(); // make the cube gree
            trackController.isHeld = false; // set the bool for isHeld to false on the Track Controller script
            Debug.Log("FingerPinch"); // debug to log Finger Pinch
        }
        else // otherwise
        {
            //not pinching
            theCube.SetRed(); // set the cube to red
        }

        float ringFingerPinchStrength = hand.GetFingerPinchStrength(OVRHand.HandFinger.Ring); // this is not used for now and will be used later as per Geoff
    }
}
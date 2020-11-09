using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRig : MonoBehaviour
{
    public Transform touchL;
    public Transform touchR;

    // Update is called once per frame
    void Update()
    {
        touchL.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        touchR.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);

        touchL.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
        touchR.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);

    }
}

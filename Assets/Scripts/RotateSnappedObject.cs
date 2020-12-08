using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using System.Linq;

public class RotateSnappedObject : MonoBehaviour
{
    [SerializeField]
    XRNode xRNodeB = XRNode.RightHand; // reference to the XR node (right hand)
    readonly List<InputDevice> devices = new List<InputDevice>(); // read only list of input devices
    InputDevice device; // reference to our input device

    void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(xRNodeB, devices); // get any input devices connected
        device = devices.FirstOrDefault(); // set our device to the first or default in the input device list
    }

    void OnEnable()
    {
        if (!device.isValid) // if not equal to device is valid (there is no device)
        {
            GetDevice(); // call the get device function
        }
    }

    IEnumerator RotateMe(Vector3 byAngles, float inTime)
    {
        var fromAngle = transform.rotation;
        var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
        for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
        {
            transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }
    }
    void Update()
    {
        List<InputFeatureUsage> features = new List<InputFeatureUsage>(); // create a new list for our input features
        device.TryGetFeatureUsages(features); // get all of the features of any type of device connected

        if (device.TryGetFeatureValue(CommonUsages.primaryButton, out bool buttonValue) && buttonValue) // if the primary button for the controller is pressed
        {
            StartCoroutine(RotateMe(Vector3.up * 90, 0.8f));
        }

        if (device.TryGetFeatureValue(CommonUsages.secondaryButton, out bool buttonValue2) && buttonValue2) // if the secondary button for the controller is pressed
        {
            StartCoroutine(RotateMe(Vector3.up * -90, 0.8f));
        }
    }
}

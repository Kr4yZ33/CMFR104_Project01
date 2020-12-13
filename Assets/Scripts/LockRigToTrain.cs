using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRigToTrain : MonoBehaviour
{
    public Transform trainRideCamera; // Reference to our VR Rig
    public Transform trainRideTransform; // Reference to the train we are going to lock our rig to

    // Update is called once per frame
    void Update()
    {
        LockRigToTrainPrefab(); // call the function to lock the train ride camera to the train
    }

    /// <summary>
    /// private function to lock the transform of the ride the train camera to the train
    /// </summary>
    void LockRigToTrainPrefab()
    {
        trainRideCamera.position = trainRideTransform.position; // set the rain ride cameras transform to the train's transform
        //vRRig.transform.rotation = train.transform.rotation;
    }
}

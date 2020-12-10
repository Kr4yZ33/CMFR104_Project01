﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRigToTrain : MonoBehaviour
{
    public Transform trainRideCamera; // Reference to our VR Rig
    public Transform trainRideTransform; // Reference to the train we are going to lock our rig to

    // Update is called once per frame
    void Update()
    {
        LockRigToTrainPrefab();
    }

    void LockRigToTrainPrefab()
    {
        trainRideCamera.position = trainRideTransform.position;
        //vRRig.transform.rotation = train.transform.rotation;
    }
}

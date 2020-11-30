using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRigToTrain : MonoBehaviour
{
    public Transform vRRig; // Reference to our VR Rig
    public Transform train; // Reference to the train we are going to lock our rig to

    // Update is called once per frame
    void Update()
    {
        LockRigToTrainPrefab();
    }

    void LockRigToTrainPrefab()
    {
        vRRig.transform.position = train.transform.position;
        //vRRig.transform.rotation = train.transform.rotation;
    }
}

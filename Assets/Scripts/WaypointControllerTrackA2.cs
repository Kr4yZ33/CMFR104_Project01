﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA2 : MonoBehaviour
{
    public TrackAreaController tracAreaController;

    public bool trainPassingTransform;

    public Transform a;
    public Transform a2;

    public Transform testingTarget;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = true;
            if (tracAreaController.currentTarget.name == "A2" && tracAreaController.initialTarget.name == "A1")
            {
                tracAreaController.previousTarget = a2;
                //tracAreaController.currentVector = locate closet tranform tagged as edge that does not have the bool for passing train == true

                transform.position = Vector3.MoveTowards(transform.position, tracAreaController.currentTarget.position, Time.deltaTime * tracAreaController.trainSpeed);

                trainPassingTransform = false;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = true;
        }
    }
}

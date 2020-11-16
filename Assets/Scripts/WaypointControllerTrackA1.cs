﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA1 : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script
    public TrackSnapConnection trackSnapConnection;

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform a1;
    public Transform a2;

    private void Update()
    {
        closestEdge = trackSnapConnection.closestEdge;
    }

    void OnTriggerEnter(Collider other)
    {
        if(trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {
            if (trainController.previousTarget != a2)
            {
                trainController.previousTarget = a1;
                trainController.currentTarget = a2;
                trainPassingTransform = true;
            }
            if (trainController.previousTarget == a2)
            {
                trainController.previousTarget = a1;
                trainController.currentTarget = closestEdge;
                trainPassingTransform = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = false;
            closestEdge = null;
        }
    }
}

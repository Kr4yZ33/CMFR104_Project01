﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointReverseDirectionRight : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script
    public TrackSnapConnection trackSnapConnection;

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform r1;

    private void Update()
    {
        closestEdge = trackSnapConnection.closestEdge;
    }

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {
            trainController.previousTarget = r1;
            trainController.currentTarget = closestEdge;
            trainPassingTransform = true;
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

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA1 : MonoBehaviour
{
    public TrackAreaController trackAreaController;

    public bool trainPassingTransform;

    public Transform a;
    public Transform a1;

    void OnTriggerEnter(Collider other)
    {
        if(trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {
            trackAreaController.previousTarget = a1;
            trackAreaController.currentTarget = a;
            trackAreaController.initialTarget = a1;
            trainPassingTransform = true;
        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = false;
        }
    }
}

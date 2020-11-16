﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerStationS2 : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform s;
    public Transform s2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;
        }
        if (other.CompareTag("Train"))
        {
            if (trainController.previousTarget != s)
            {
                trainController.previousTarget = s2;
                trainController.currentTarget = s;
                trainPassingTransform = true;
            }

            if (trainController.previousTarget == s)
            {
                trainController.previousTarget = s2;
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
        }
    }
}

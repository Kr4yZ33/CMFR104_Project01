using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointReverseDirectionRight : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform r1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainController.previousTarget = r1;
            trainController.currentTarget = closestEdge;
            trainController.edgeTransition = true;
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

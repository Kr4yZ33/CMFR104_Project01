using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointReverseDirectionLeft : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform r2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {
            trainController.previousTarget = r2;
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

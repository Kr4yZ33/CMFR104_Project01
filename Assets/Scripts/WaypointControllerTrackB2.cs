using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackB2 : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform b1;
    public Transform b2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {
            if (trainController.previousTarget != b1)
            {
                trainController.previousTarget = b2;
                trainController.currentTarget = b1;
                trainPassingTransform = true;
            }
            if (trainController.previousTarget == b1)
            {
                trainController.previousTarget = b2;
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

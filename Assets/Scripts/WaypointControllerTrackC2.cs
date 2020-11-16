using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackC2 : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform c;
    public Transform c2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;
        }
        if (other.CompareTag("Train"))
        {
            if (trainController.previousTarget != c)
            {
                trainController.previousTarget = c2;
                trainController.currentTarget = c;
                trainPassingTransform = true;
            }

            if (trainController.previousTarget == c)
            {
                trainController.previousTarget = c2;
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

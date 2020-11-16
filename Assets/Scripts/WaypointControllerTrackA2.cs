using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA2 : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform a1;
    public Transform a2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {
            if (trainController.previousTarget != a1)
            {
                trainController.previousTarget = a2;
                trainController.currentTarget = a1;
                trainPassingTransform = true;
            }
            if (trainController.previousTarget == a1)
            {
                trainController.previousTarget = a2;
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

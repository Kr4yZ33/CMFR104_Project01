using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackC1 : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform c1;
    public Transform c;

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
                trainController.previousTarget = c1;
                trainController.currentTarget = c;
                trainPassingTransform = true;
            }

            if (trainController.previousTarget == c)
            {
                trainController.previousTarget = c1;
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

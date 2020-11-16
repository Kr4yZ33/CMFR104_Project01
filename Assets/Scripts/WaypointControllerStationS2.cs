using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerStationS2 : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform s1;
    public Transform s2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {
            if (trainController.currentTarget == closestEdge) // This is the first piece of track the train has hit since being placed
            {
                trainController.previousTarget = s1;
                trainController.currentTarget = s2;
                trainController.edgeTransition = true;
                trainPassingTransform = true;
            }

            if (trainController.edgeTransition == true)
            {
                trainController.edgeTransition = false;
                trainController.previousTarget = s1;
                trainController.currentTarget = s2;
                trainPassingTransform = true;
            }
            else
            {
                trainController.previousTarget = s2;
                trainController.currentTarget = closestEdge;
                trainController.edgeTransition = true;
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

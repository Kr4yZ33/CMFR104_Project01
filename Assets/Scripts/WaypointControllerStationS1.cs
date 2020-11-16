using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerStationS1 : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform s1;
    public Transform s2;
    public Transform s;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {
            if (trainController.previousTarget == s) // This is the first piece of track the train has hit since being placed
            {
                trainController.previousTarget = s1;
                trainController.currentTarget = closestEdge;
                trainController.edgeTransition = true;
                trainPassingTransform = true;
            }

            if (trainPassingTransform == true)
            {
                return;
            }
            if (trainController.edgeTransition == true)
            {
                trainController.edgeTransition = false;
                trainController.previousTarget = s1;
                trainController.currentTarget = s2;
                trainPassingTransform = true;
            }
            if (trainController.edgeTransition != true)
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

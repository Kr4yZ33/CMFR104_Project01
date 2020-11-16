using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointReverseDirectionLeft : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform r1;
    public Transform r2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {

            if (trainController.currentTarget == trainController.startingPos) // This is the first piece of track the train has hit since being placed
            {
                trainController.previousTarget = r2;
                trainController.currentTarget = r1;
                trainPassingTransform = true;
            }

            if (trainController.edgeTransition == true)
            {
                trainController.edgeTransition = false;
                trainController.previousTarget = r2;
                trainController.currentTarget = r1;
                trainPassingTransform = true;
            }
            else
            {
                trainController.previousTarget = r1;
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

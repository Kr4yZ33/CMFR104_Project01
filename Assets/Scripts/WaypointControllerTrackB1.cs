using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackB1 : MonoBehaviour
{
    public TrainController trainController; // reference to the TrackAreaController script

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
            if (trainController.currentTarget == trainController.startingPos) // This is the first piece of track the train has hit since being placed
            {
                trainController.previousTarget = b1;
                trainController.currentTarget = b2;
                trainPassingTransform = true;
            }

            if (trainController.edgeTransition == true)
            {
                trainController.edgeTransition = false;
                trainController.previousTarget = b1;
                trainController.currentTarget = b2;
                trainPassingTransform = true;
            }
            else
            {
                trainController.previousTarget = b2;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA1 : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform a1;
    public Transform a2;

    void OnTriggerEnter(Collider other)
    {
        if(trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {
            if (trainController.currentTarget == trainController.startingPos) // This is the first piece of track the train has hit since being placed
            {
                trainController.previousTarget = a1;
                trainController.currentTarget = a2;
                trainPassingTransform = true;
            }
              
            if (trainController.edgeTransition == true)
            {
                trainController.edgeTransition = false;
                trainController.previousTarget = a1;
                trainController.currentTarget = a2;
                trainPassingTransform = true;
            }
            else
            {
                trainController.previousTarget = a2;
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

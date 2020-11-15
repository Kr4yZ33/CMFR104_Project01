using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA2 : MonoBehaviour
{
    public TrackAreaController trackAreaController; // reference to the TrackAreaController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform a;
    public Transform a2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }

        if (other.CompareTag("Train"))
        {
            if(trackAreaController.previousTarget != a)
            {
                trackAreaController.previousTarget = a2;
                trackAreaController.currentTarget = a;
                trainPassingTransform = true;
            }
            else
            {
                trackAreaController.previousTarget = a2;
                //tracAreaController.currentVector = locate closet tranform tagged as edge that does not have the bool for passing train == true
                trackAreaController.currentTarget = closestEdge;
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

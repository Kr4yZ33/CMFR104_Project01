using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA1 : MonoBehaviour
{
    public TrackAreaController trackAreaController; // reference to the TrackAreaController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform a;
    public Transform a1;

    void OnTriggerEnter(Collider other)
    {
        if(trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {

            if (trackAreaController.previousTarget != a)
            {
                trackAreaController.previousTarget = a1;
                trackAreaController.currentTarget = a;
                trainPassingTransform = true;
            }
            else
            {
                trackAreaController.previousTarget = a1;
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

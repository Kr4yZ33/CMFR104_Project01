using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackB2 : MonoBehaviour
{
    public TrackAreaController trackAreaController;

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform b;
    public Transform b2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }

        if (other.CompareTag("Train"))
        {
            if(trackAreaController.previousTarget != b)
            {
                trackAreaController.currentTarget = b;
                trackAreaController.previousTarget = b2;
                trainPassingTransform = true;
            }
            
            trackAreaController.previousTarget = b;
            trackAreaController.currentTarget = closestEdge;
            trainPassingTransform = true;
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

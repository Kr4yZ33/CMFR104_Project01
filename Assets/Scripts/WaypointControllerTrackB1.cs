using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackB1 : MonoBehaviour
{
    public TrackAreaController trackAreaController; // reference to the TrackAreaController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform b;
    public Transform b1;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {

            if (trackAreaController.previousTarget != b)
            {
                trackAreaController.previousTarget = b1;
                trackAreaController.currentTarget = b;
                trainPassingTransform = true;
            }
            else
            {
                trackAreaController.previousTarget = b1;
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

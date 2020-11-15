using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackC2 : MonoBehaviour
{
    public TrackAreaController trackAreaController;

    public bool trainPassingTransform;


    public Transform closestEdge;
    public Transform c;
    public Transform c2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }

        if (other.CompareTag("Train"))
        {
            if (trackAreaController.previousTarget != c)
            {
                trackAreaController.currentTarget = c;
                trackAreaController.previousTarget = c2;
                trainPassingTransform = true;
            }
            else
            {
                trackAreaController.previousTarget = c2;
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

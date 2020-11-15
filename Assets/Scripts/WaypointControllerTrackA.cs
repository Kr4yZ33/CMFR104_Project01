using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA : MonoBehaviour
{
    public TrackAreaController trackAreaController; // reference to the TrackAreaController script

    public bool trainPassingTransform;

    public Transform a;
    public Transform a1;
    public Transform a2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }

        if (other.CompareTag("Train"))
        {
            if(trackAreaController.previousTarget == a2)
            {
                trackAreaController.previousTarget = a;
                trackAreaController.currentTarget = a1;
                trainPassingTransform = true;
            }
            else
            {
                trackAreaController.previousTarget = a;
                trackAreaController.currentTarget = a2;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA : MonoBehaviour
{
    public TrackAreaController trackAreaController;

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
            trackAreaController.previousTarget = a;
            trackAreaController.currentTarget = a2;
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

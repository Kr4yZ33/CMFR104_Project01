using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackC : MonoBehaviour
{
    public TrackAreaController trackAreaController;

    public bool trainPassingTransform;

    public Transform c;
    public Transform c1;
    public Transform c2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }

        if (other.CompareTag("Train"))
        {
            trackAreaController.previousTarget = c;
            trackAreaController.currentTarget = c2;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA2 : MonoBehaviour
{
    public TrackAreaController trackAreaController;

    public bool trainPassingTransform;

    public Transform b1;
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
            trackAreaController.previousTarget = a2;
            //tracAreaController.currentVector = locate closet tranform tagged as edge that does not have the bool for passing train == true
            trackAreaController.currentTarget = b1;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackB2 : MonoBehaviour
{
    public TrackAreaController trackAreaController;

    public bool trainPassingTransform;

    public Transform c1;
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
            trackAreaController.previousTarget = b;
            //tracAreaController.currentVector = locate closet tranform tagged as edge that does not have the bool for passing train == true
            trackAreaController.currentTarget = c1;
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

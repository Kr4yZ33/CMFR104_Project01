using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackC2 : MonoBehaviour
{
    public TrackAreaController trackAreaController;

    public bool trainPassingTransform;

    public Transform c1;
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
            trackAreaController.previousTarget = c;
            //tracAreaController.currentVector = locate closet tranform tagged as edge that does not have the bool for passing train == true

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA1 : MonoBehaviour
{
    public TrackAreaController tracAreaController;

    public bool trainPassingTransform;

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
            tracAreaController.previousTarget = a1;
            tracAreaController.currentTarget = a;
            tracAreaController.initialTarget = a1;
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

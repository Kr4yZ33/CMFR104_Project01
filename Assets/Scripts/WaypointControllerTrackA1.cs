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
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = true;
            if (tracAreaController.currentTarget == a1)
            {
                tracAreaController.previousTarget = a1;
                tracAreaController.currentTarget = a;
                tracAreaController.initialTarget = a1;

                transform.position = Vector3.MoveTowards(transform.position, tracAreaController.currentTarget.position, Time.deltaTime * tracAreaController.trainSpeed);
                trainPassingTransform = false;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = true;
        }
    }
}

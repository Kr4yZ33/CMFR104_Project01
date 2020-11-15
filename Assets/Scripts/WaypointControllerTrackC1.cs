using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackC1 : MonoBehaviour
{
    public TrackAreaController tracAreaController;

    public bool trainPassingTransform;

    public Transform c;
    public Transform c1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = true;
            if (tracAreaController.currentTarget == c1)
            {
                tracAreaController.previousTarget = c1;
                tracAreaController.currentTarget = c;
                tracAreaController.initialTarget = c1;

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

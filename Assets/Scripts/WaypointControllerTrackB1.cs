using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackB1 : MonoBehaviour
{
    public TrackAreaController tracAreaController;

    public bool trainPassingTransform;

    public Transform b;
    public Transform b1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = true;
            if (tracAreaController.currentTarget == b1)
            {
                tracAreaController.previousTarget = b1;
                tracAreaController.currentTarget = b;
                tracAreaController.initialTarget = b1;

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

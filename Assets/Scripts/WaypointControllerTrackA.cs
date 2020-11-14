using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA : MonoBehaviour
{
    public TrackAreaController tracAreaController;

    public bool trainPassingTransform;

    public Transform a;
    public Transform a1;
    public Transform a2;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = true;
            if (tracAreaController.currentTarget.name == "A" && tracAreaController.initialTarget.name == "A1")
            {
                tracAreaController.previousTarget = a;
                tracAreaController.currentTarget = a2;

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

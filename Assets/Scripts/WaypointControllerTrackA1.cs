using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA1 : MonoBehaviour
{
    public TrackAreaController tracAreaController;

    public bool trainPassingTransform;
    
    public Transform a;
    public Transform a1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = true;
            if (tracAreaController.currentTarget.name == "A1")
            {
                tracAreaController.previousVector = a1.position;
                tracAreaController.targetVector = a.position;
                tracAreaController.initialVector = a1.position;

                transform.position = Vector3.MoveTowards(transform.position, tracAreaController.targetVector, Time.deltaTime * tracAreaController.trainSpeed);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = false;
        }
    }
}

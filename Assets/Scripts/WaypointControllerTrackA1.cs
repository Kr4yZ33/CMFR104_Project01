using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA1 : MonoBehaviour
{
    public TrainController trainController;
    public TrackAreaController tracAreaController;

    public bool trainPassingTransform;
    
    public Transform a;
    public Transform a1;

    private void OnTriggerEnter(Collider other)
    {
        if (tracAreaController.currentTarget.name == "A1")
        {
            tracAreaController.previousTarget = a1;
            tracAreaController.currentTarget = a;
            tracAreaController.initialTarget = a1;

            other.transform.position = Vector3.MoveTowards(transform.position, tracAreaController.currentTarget.transform.position, Time.deltaTime * tracAreaController.trainSpeed);
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

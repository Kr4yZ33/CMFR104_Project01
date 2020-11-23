using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA2 : MonoBehaviour
{
    public TrackSnapConnection trackSnapConnection;
    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform a1;
    public Transform a2;

    private void FixedUpdate()
    {
        closestEdge = trackSnapConnection.closestEdge;
    }

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {
            TrainController script = other.gameObject.GetComponent<TrainController>();

            if (script.previousTarget != a1)
            {
                script.previousTarget = a2;
                script.currentTarget = a1;
                trainPassingTransform = true;
            }
            if (script.previousTarget == a1)
            {
                script.previousTarget = a2;
                script.currentTarget = closestEdge;
                trainPassingTransform = true;
            }
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

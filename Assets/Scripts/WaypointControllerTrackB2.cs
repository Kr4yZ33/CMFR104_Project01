using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackB2 : MonoBehaviour
{
    public TrackSnapConnection trackSnapConnection;

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform b1;
    public Transform b2;

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

            if (script.previousTarget != b1)
            {
                script.previousTarget = b2;
                script.currentTarget = b1;
                trainPassingTransform = true;
            }
            if (script.previousTarget == b1)
            {
                script.previousTarget = b2;
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

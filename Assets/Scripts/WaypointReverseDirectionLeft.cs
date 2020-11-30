using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointReverseDirectionLeft : MonoBehaviour
{
    public TrackSnapConnection trackSnapConnection; // reference to the Track Snap COnnection script

    public bool trainPassingTransform; // bool for if the train is passing the transform or not

    public Transform closestEdge;  // Reference to the closest edge from another tile next to this transform
    public Transform r2;

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

            script.previousTarget = r2;
            script.currentTarget = closestEdge;
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

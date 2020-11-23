using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointReverseDirectionRight : MonoBehaviour
{
    public TrackSnapConnection trackSnapConnection;

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform r1;

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

            script.previousTarget = r1;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackA1 : MonoBehaviour
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
        if(trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {
            TrainController script = other.gameObject.GetComponent<TrainController>();

            if (script.previousTarget != a2)
            {
                script.previousTarget = a1;
                script.currentTarget = a2;
                trainPassingTransform = true;
            }
            if (script.previousTarget == a2)
            {
                script.previousTarget = a1;
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

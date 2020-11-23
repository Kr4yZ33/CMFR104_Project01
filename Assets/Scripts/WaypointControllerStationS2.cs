using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerStationS2 : MonoBehaviour
{
    public TrackSnapConnection trackSnapConnection;

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform s1;
    public Transform s2;

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
                        
            if (script.previousTarget != s1)
            {
                script.previousTarget = s2;
                script.currentTarget = s1;
                trainPassingTransform = true;
            }
            if (script.previousTarget == s1)
            {
                script.previousTarget = s2;
                closestEdge = trackSnapConnection.closestEdge;
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

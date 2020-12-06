using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointRightEdgeControllerC : MonoBehaviour
{
    public HapticsController hapticsController;
    public bool trainPassingTransform;

    public Transform centre;
    public Transform closestEdge;
    public Transform right;
    public Transform left;

    private void FixedUpdate()
    {
        if (closestEdge == null)
        {
            closestEdge = gameObject.transform;
        }
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

            if (script.previousTarget != centre)
            {
                script.previousTarget = right;
                script.currentTarget = centre;
                trainPassingTransform = true;
            }
            if (script.previousTarget == centre)
            {
                script.previousTarget = right;
                script.currentTarget = closestEdge;
                trainPassingTransform = true;
            }
        }

        if (other.CompareTag("TrackEdge"))
        {
            closestEdge = other.transform;
            hapticsController.trackConnected = true;
            hapticsController.PlayTrackConnectionClip();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            trainPassingTransform = false;
        }
        if (other.CompareTag("TrackEdge"))
        {
            closestEdge = null;
            hapticsController.trackConnected = false;
            hapticsController.trackConnectClipPlayed = false;
        }
    }
}
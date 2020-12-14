using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseEdgeWaypointController : MonoBehaviour
{
    public HapticsController hapticsController; // reference to the haptics controller script

    public bool trainPassingTransform; // bool for if the train is passing the edge transfor or not

    public Transform centre; // transofrm in the centre of the track tile
    public Transform closestEdge; // the closes external edge to this edge waypoint
    public Transform reverseEdge; // reference to the reverse edhe for the reverse dierction train tile

    /// <summary>
    /// on trigger enter
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true) // if the bool for train passing transformj is true
        {
            return; // exit the script

        }
        if (other.CompareTag("Train")) // if the thing colliding with us has the tag Train
        {

            TrainController script = other.gameObject.GetComponent<TrainController>(); // access the game object and get the train controller script from it (saves us having to assign manually)

            if (script != null && script.previousTarget != centre) // if the train controller's previous target was not the centre
            {
                script.previousTarget = reverseEdge; // set the previous target on the train controller script to the reverse edge
                script.currentTarget = centre; // set the current target on the train controller script to the centre transform of the track tile
                trainPassingTransform = true; // set the train passing transform bool to true
            }
            if (script != null && script.previousTarget == centre) // if the train controller's previous target was the centre
            {
                script.previousTarget = reverseEdge; // set the previous target on the train controller script to the reverse edge
                trainPassingTransform = true;  // set the train passing transform bool to true
                if(closestEdge != null)
                {
                    script.currentTarget = closestEdge; // set the current target on the train controller script to the closest edge
                }
            }
        }

        if (other.CompareTag("TrackEdge")) // if the thing colliding with us is tagged TrackEdge
        {
            closestEdge = other.gameObject.transform; // set the closest edge transform to the transform of the object that just collided with us.
            hapticsController.trackConnected = true; // set the bool for track connected to true on the  haptics controller script
            hapticsController.PlayTrackConnectionClip(); // call the function to play the track connection clip fom the haptics controller script
        }
    }

    /// <summary>
    /// on trigger exit
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Train")) // if the thing leaving out collider is tagged Train
        {
            trainPassingTransform = false; // set the train passing bool transfor to false
        }
        if (other.CompareTag("TrackEdge")) // if the thing leaving out collider is tagged TrackEdge
        {
            closestEdge = null; // set the closest edge to null
            hapticsController.trackConnected = false; // set the bool for trackj connected to true on the  haptics controller script
            hapticsController.trackConnectClipPlayed = false; // set the bool for track connect clip played to true on the  haptics controller script
        }

    }
}

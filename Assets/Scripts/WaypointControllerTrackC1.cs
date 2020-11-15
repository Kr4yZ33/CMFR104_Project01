using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackC1 : MonoBehaviour
{
    public TrackAreaController trackAreaController; // reference to the TrackAreaController script

    public bool trainPassingTransform; // bool to show if the train is passing the transform and allow us to stop the update function from running when it doesnt need to

    public Transform closestEdge; // reference to the transform or the closeses connected edge piece
    public Transform c; // The middle transform of the track piece
    public Transform c1; // The edge transform of the track piece

    /// <summary>
    /// Trigger Events detection to know where the train is coming from
    /// and where it needs to be sent to next
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return; // exit script

        }

        if (other.CompareTag("Train")) // if the thing colliding with us has the tag Train
        {
            if(trackAreaController.previousTarget != c) // if the train was not coming from the centre
            {
                trackAreaController.currentTarget = c; // set the current target to the centre
                trackAreaController.previousTarget = c1; // set the previous target to this transform
                trainPassingTransform = true; // set the bool for trainPassing to true
            }
            else // otherwise
            {
                trackAreaController.previousTarget = c1; // set the pervious target to this transform
                trackAreaController.currentTarget = closestEdge; // set the current target to the closest edge transform
                trainPassingTransform = true; // set the bool for trainPassing to true
            }
        }
    }

    /// <summary>
    /// When the object exits my collider
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Train")) // if the object has the tag Train
        {
            trainPassingTransform = false; // set the trainPassing bool to false.
        }
    }
}

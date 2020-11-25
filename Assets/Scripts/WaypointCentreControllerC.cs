using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointCentreControllerC : MonoBehaviour
{
    public Transform rightEdge; // reference to the right edge transform of the track tile
    public Transform leftEdge; // reference to the left edge transform of the track tile
    public Transform centre; // reference to the centre edge transform of the track tile
    public bool trainPassingTransform; // bool for if the train is passing the transform or not

    void OnTriggerEnter(Collider other) // on trigger enter
    {
        if (trainPassingTransform == true) // if the bool for train passing transform is true
        {
            return; // exit function 

        }
        if (other.CompareTag("Train")) // if the thing hitting us is tagged Train
        {

            TrainController script = other.gameObject.GetComponent<TrainController>(); // Set script to be the Train Controller script, get it from the object colliding with us

            if (script.previousTarget != rightEdge) // if train's previous target is not equal to right edge transform
            {
                script.previousTarget = centre; // set the trains previous target to centre transform
                script.currentTarget = rightEdge; // set the train's current target to the right edge transform
                trainPassingTransform = true; // set the train passing bool to true
            }

            if (script.previousTarget == rightEdge) // if train's previous target is equal to right edge transform
            {
                script.previousTarget = centre; // set the trains previous target to centre transform
                script.currentTarget = leftEdge; // set the trains current target to left edge transform
                trainPassingTransform = true; // set the train passing bool to true
            }

        }
    }

    void OnTriggerExit(Collider other) // on trigger exit
    {
        if (other.CompareTag("Train")) // if the thing leaving us is tagged train
        {
            trainPassingTransform = false; // set the train passing bool to false (so we can set our tagets again next time the train passes this transform)
        }
    }
}

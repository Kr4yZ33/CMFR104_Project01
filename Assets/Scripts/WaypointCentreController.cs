using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointCentreController : MonoBehaviour
{
    public Transform rightEdge;
    public Transform leftEdge;
    public Transform centre;
    public bool trainPassingTransform; // bool for if the train is passing the transform or not

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }
        if (other.CompareTag("Train"))
        {

            TrainController script = other.gameObject.GetComponent<TrainController>();

            if(script.previousTarget != rightEdge)
            {
                script.previousTarget = centre;
                script.currentTarget = rightEdge;
                trainPassingTransform = true;
            }

            if (script.previousTarget == rightEdge)
            {
                script.previousTarget = centre;
                script.currentTarget = leftEdge;
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

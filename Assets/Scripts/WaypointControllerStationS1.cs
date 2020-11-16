using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerStationS1 : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform closestEdge;
    public Transform s1;
    public Transform s;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }

        if (other.CompareTag("Train"))
        {

            if (trainController.previousTarget != s)
            {
                trainController.previousTarget = s1;
                trainController.currentTarget = s;
                trainPassingTransform = true;
            }

            if (trainController.previousTarget == s)
            {
                trainController.previousTarget = s1;
                trainController.currentTarget = closestEdge;
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

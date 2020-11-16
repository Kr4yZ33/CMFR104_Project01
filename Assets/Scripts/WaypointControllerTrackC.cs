using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerTrackC : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

    public Transform c2;
    public Transform c1;
    public Transform c;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }

        if (other.CompareTag("Train"))
        {

            if (trainController.previousTarget == c1)
            {
                trainController.previousTarget = c;
                trainController.currentTarget = c2;
                trainPassingTransform = true;
            }

            if (trainController.previousTarget == c2)
            {
                trainController.previousTarget = c;
                trainController.currentTarget = c1;
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

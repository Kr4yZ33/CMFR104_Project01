using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerStationS : MonoBehaviour
{
    public TrainController trainController; // reference to the TrainController script

    public bool trainPassingTransform;

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
            trainController.previousTarget = s;
            trainController.currentTarget = s1;
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

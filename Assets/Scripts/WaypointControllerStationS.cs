using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointControllerStationS : MonoBehaviour
{
    public bool trainPassingTransform;

    public Transform s1;
    public Transform s2;

    void OnTriggerEnter(Collider other)
    {
        if (trainPassingTransform == true)
        {
            return;

        }

        if (other.CompareTag("Train"))
        {
            TrainController script = other.gameObject.GetComponent<TrainController>();
            
            
            script.previousTarget = s2;
            script.currentTarget = s1;
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

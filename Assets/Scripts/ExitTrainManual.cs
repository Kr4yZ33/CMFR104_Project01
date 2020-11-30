using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrainManual : MonoBehaviour
{
    public RideTheTrain rideTheTrain;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LeftHand"))
        {
            rideTheTrain.ExitTrain();
        }
        if (other.CompareTag("RightHand"))
        {
            rideTheTrain.ExitTrain();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrainTileController : MonoBehaviour
{
    public RideTheTrain rideTheTrain;
    public RigScaleController rigScaleController;
    public GameObject lockRigToTrain;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Train"))
        {
            Debug.Log("Exit Train tile first step");

            if (rideTheTrain.ridingTrain == true)
            {
                Debug.Log("Exit train tile last step");
                lockRigToTrain.SetActive(false);
                rideTheTrain.ridingTrain = false;
                rigScaleController.ChangeScaleToLarge();
            }
        }   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideTheTrain : MonoBehaviour
{
    public RigScaleController rigScaleController;
    public Transform trainExitTransform; // reference to the transform the rig will jump to when exiting the train in small scale rig mode
    public GameObject rigLockToTrain; // reference to the game object that we will turn on and off to lock our VR Rig to the train
    public GameObject trainStation;
    public bool playerAtStation;
    public bool ridingTrain;

    private void Update()
    {
        if(rigScaleController.manualTrainRide == true)
        {
            playerAtStation = true;
        }
        
        if(ridingTrain == true)
        {
            return;
        }
        else if(playerAtStation == true)
        {
            ridingTrain = true;
            RideTrain();
        }


    }

    void RideTrain()
    {
        rigLockToTrain.SetActive(true);
    }

    public void ExitTrain()
    {
        rigLockToTrain.SetActive(false);
        ridingTrain = false;
        rigScaleController.ChangeScaleToLarge();
    }

    public void ManualTrainRide()
    {
        ridingTrain = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("SmallPlayer"))
        {
            playerAtStation = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("SmallPlayer"))
        {
            playerAtStation = false;
        }
    }


}
